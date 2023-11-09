using EntityData.Interfaces;
using EntityData.Models;
using EntityData.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityData.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly DataContext _dataContext;
        public UserRepository(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<User> CreateAsync(User user)
        {
        
            await _dataContext.Users.AddAsync(user);
            await _dataContext.SaveChangesAsync();

            return user;
        }

        public async Task DeleteAsync(Guid id)
        {
            var userToDelete = await _dataContext.Users.FindAsync(id);

            if (userToDelete == null)
                throw new NotImplementedException();

            _dataContext.Users.Remove(userToDelete);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dataContext.Users.ToListAsync();
        }

        public async Task<User> GetAsync(Guid id)
        {
           var user = await _dataContext.Users.Include("ALGO").SingleOrDefaultAsync(p => p.Id == id);

           if(user == null)
            throw new NotImplementedException();
           
            return user;
        }

        public async Task<User> UpdateAsync(User user)
        {
            var userUpdated = await _dataContext.Users.FindAsync(user.Id);

            if (userUpdated == null)
             throw new NotImplementedException();

            _dataContext.Entry(userUpdated).CurrentValues.SetValues(user);
            _dataContext.Users.Update(userUpdated);
            await _dataContext.SaveChangesAsync();

            return userUpdated;
        }
    }
}
