using API.RenalReviews.Models;
using API.RenalReviews.Services;
using API.RentalReviews.Views.User;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.RentalReviews.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _usersService;
        private readonly IMapper _mapper;

        public UserController(UserService usersService, IMapper mapper) {
           
            _usersService = usersService;
            _mapper = mapper;
        }
            
        [HttpGet]
        public async Task<List<User>> Get() =>
            await _usersService.GetAllAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<User>> GetById(string id)
        {
            var user = await _usersService.GetByIdAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserPostView userPostView)
        {

            var user = _mapper.Map<User>(userPostView);

            await _usersService.CreateAsync(user);

            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, User updatedUser)
        {
            var user = await _usersService.GetByIdAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            updatedUser.Id = user.Id;

            await _usersService.UpdateAsync(id, updatedUser);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _usersService.GetByIdAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            await _usersService.DeleteAsync(id);

            return NoContent();
        }
    }
}
