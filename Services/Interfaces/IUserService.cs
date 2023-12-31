﻿using EntityData.Models;
using ServicesDomain.Views.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesDomain.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateAsync(UserCreationView userCreationView);
        Task<List<User>> GetAllAsync();
        Task<User> GetAsync(Guid id);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(Guid id);
    }
}
