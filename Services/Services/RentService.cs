using EntityData.DatabaseSettings;
using EntityData.Models;
using Microsoft.Extensions.Options;
using ServicesDomain.Interfaces;

namespace ServicesDomain.Services
{
    public class RentService : IRentService
    {

 
        public RentService()
        {
           
        }

        public async Task CreateAsync(Rent newRent)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Rent>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Rent> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(string id, Rent updatedRent)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(string id) =>
           throw new NotImplementedException();

        public async Task UpdateReviewsAsync(string id, Review reviewUpdate)
        {
            throw new NotImplementedException();

        }
    }
}
