using EntityData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityData.Interfaces
{
    public interface IUserRepository
    {
        Task<User> CreateAsync(User user);
        Task<List<User>> GetAllAsync();
        Task<User> GetAsync(Guid id);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(Guid id);
    }
}
