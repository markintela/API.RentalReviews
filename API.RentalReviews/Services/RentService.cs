using API.RenalReviews.Models;
using API.RentalReviews.DatabaseSettings;
using API.RentalReviews.Interfaces;
using API.RentalReviews.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace API.RentalReviews.Services
{
    public class RentService : IRentService
    {

        private readonly IMongoCollection<Rent> _rentsCollection;

        public RentService(
            IOptions<RentStoreDatabaseSettings> rentStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                rentStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                rentStoreDatabaseSettings.Value.DatabaseName);

            _rentsCollection = mongoDatabase.GetCollection<Rent>(
                rentStoreDatabaseSettings.Value.RentsCollectionName);
        }


        public async Task CreateAsync(Rent newRent)
        {
            await _rentsCollection.InsertOneAsync(newRent);
        }

        public async Task<List<Rent>> GetAllAsync()
        {
            return await _rentsCollection.Find(_ => true).ToListAsync();
        }

        public async Task<Rent> GetByIdAsync(string id)
        {
            return await _rentsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(string id, Rent updatedRent)
        {
            Builders<Rent>.Filter.Eq(x => x.Id, updatedRent.Id);
            Builders<Rent>.Update.Set(x => x.Reviews, updatedRent.Reviews);
            Builders<Rent>.Update.Set(x => x.Location, updatedRent.Location);
            await _rentsCollection.ReplaceOneAsync(x => x.Id == id, updatedRent);
        }

        public async Task DeleteAsync(string id) =>
           await _rentsCollection.DeleteOneAsync(x => x.Id == id);

    }
}
