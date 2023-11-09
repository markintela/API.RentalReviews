using AutoMapper;
using EntityData.DatabaseSettings;
using EntityData.Interfaces;
using EntityData.Models;
using Microsoft.Extensions.Options;
using ServicesDomain.Interfaces;
using ServicesDomain.Views.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesDomain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
    

        public async Task<User> CreateAsync(UserCreationView userCreationView)
        {
            var user = _mapper.Map<User>(userCreationView);
            return await _userRepository.CreateAsync(user);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetAsync(Guid id)
        {
            return await _userRepository.GetAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            return await _userRepository.UpdateAsync(user);
        }
    }
}
