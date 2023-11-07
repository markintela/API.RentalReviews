using EntityData.Models;


namespace ServicesDomain.Interfaces
{
    public interface IUserService
    {
        Task CreateAsync(User newUser);
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
        Task UpdateAsync(string id, User updatedUser);

        Task DeleteAsync(string id);
    }
}
