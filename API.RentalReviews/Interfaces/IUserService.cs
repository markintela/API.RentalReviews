using API.RenalReviews.Models;
using API.RenalReviews.Services;
using API.RentalReviews.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.RentalReviews.Interfaces
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
