using API.RenalReviews.Models;
using API.RentalReviews.DatabaseSettings;
using API.RentalReviews.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.RenalReviews.Services
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
            return await _usersCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(string id, User updatedUser)
        {
 
             await _usersCollection.ReplaceOneAsync(x => x.Id == id, updatedUser);
        }

        public async Task DeleteAsync(string id) =>
           await _usersCollection.DeleteOneAsync(x => x.Id == id);


    }
}
