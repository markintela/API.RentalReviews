using EntityData.Models;

namespace ServicesDomain.Interfaces
{
    public interface IRentService
    {
        Task CreateAsync(Rent newRent);
        Task<List<Rent>> GetAllAsync();
        Task<Rent> GetByIdAsync(string id);
        Task UpdateAsync(string id, Rent updatedRent);
        Task DeleteAsync(string id);

    }
}
