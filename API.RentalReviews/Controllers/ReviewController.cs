using API.RenalReviews.Models;
using API.RenalReviews.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.RentalReviews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly UserService _usersService;
        public ReviewController(UserService usersService) =>
            _usersService = usersService;

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
        public async Task<IActionResult> Post(User newUser)
        {
            await _usersService.CreateAsync(newUser);

            return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
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
