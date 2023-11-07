using EntityData.DatabaseSettings;
using EntityData.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ServicesDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesDomain.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _usersCollection;

        public UserService(
            IOptions<UserStoreDatabaseSettings> userStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                userStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                userStoreDatabaseSettings.Value.DatabaseName);

            _usersCollection = mongoDatabase.GetCollection<User>(
                userStoreDatabaseSettings.Value.UsersCollectionName);
        }





        public async Task CreateAsync(User newUser)
        {
            await _usersCollection.InsertOneAsync(newUser);
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _usersCollection.Find(_ => true).ToListAsync();
        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await _usersCollection.Find(x => x._id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(string id, User updatedUser)
        {

            await _usersCollection.ReplaceOneAsync(x => x._id == id, updatedUser);
        }

        public async Task DeleteAsync(string id) =>
           await _usersCollection.DeleteOneAsync(x => x._id == id);


    }
}
