using AutoMapper;
using EntityData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using ServicesDomain.Interfaces;
using ServicesDomain.Services;
using ServicesDomain.Views.User;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace API.RentalReviews.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _usersService;
        private readonly IMapper _mapper;

        public UserController(IUserService usersService, IMapper mapper) {
           
            _usersService = usersService;
            _mapper = mapper;
        }

        /// <summary>
        /// Create a new user.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Post(UserCreationView userCreationView)
        {
            var userCreated = await _usersService.CreateAsync(userCreationView);

            if (userCreated == null)
                throw new ApplicationException("User not created.");

            return CreatedAtAction(nameof(Get), new { id = userCreated.Id }, userCreated);
        }

        /// <summary>
        /// Get all users.
        /// </summary>
        [HttpGet]  
        public async Task<List<User>> Get() =>
            await _usersService.GetAllAsync();

        /// <summary>
        /// Get user by id.
        /// </summary>
        [HttpGet("{id:length(36)}")]
        public async Task<ActionResult<User>> GetById(Guid id)
        {
            var post = await _usersService.GetAsync(id);
            if (post == null)
            {
                throw new KeyNotFoundException("User not found.");
            }
            return Ok(post);
        }

        /// <summary>
        /// Update user.
        /// </summary>
        [HttpPut()]
        public async Task<IActionResult> Update(User user)
        {
            var userToUpdated = await _usersService.UpdateAsync(user);

            if (userToUpdated == null)
            {
                throw new NotImplementedException("User not updated.");
            }
            return Ok(userToUpdated);
        }

        /// <summary>
        /// Remove user.
        /// </summary>
        [HttpDelete("{id:length(36)}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _usersService.DeleteAsync(id);
            return NoContent();
        }
    }
}
