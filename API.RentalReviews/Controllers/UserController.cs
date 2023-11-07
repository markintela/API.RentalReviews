using AutoMapper;
using EntityData.Models;
using Microsoft.AspNetCore.Mvc;
using ServicesDomain.Services;
using ServicesDomain.Views.User;

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

        [HttpGet("{id:length(36)}")]
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

            return CreatedAtAction(nameof(Get), new { id = user._id }, user);
        }

        [HttpPut("{id:length(36)}")]
        public async Task<IActionResult> Update(string id, UserPutView userPutView)
        {
            var user = await _usersService.GetByIdAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            var userToUpdate = _mapper.Map<User>(userPutView);

            userToUpdate._id = user._id;

            await _usersService.UpdateAsync(id, userToUpdate);

            return NoContent();
        }

        [HttpDelete("{id:length(36)}")]
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
