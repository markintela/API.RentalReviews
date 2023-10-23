using API.RenalReviews.Models;
using API.RenalReviews.Services;
using API.RentalReviews.Models;
using API.RentalReviews.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.RentalReviews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {

        private readonly RentService _rentsService;

        public RentController(RentService rentsService) =>
            _rentsService = rentsService;

        [HttpGet]
        public async Task<List<Rent>> Get() =>
            await _rentsService.GetAllAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Rent>> GetById(string id)
        {
            var rent = await _rentsService.GetByIdAsync(id);

            if (rent is null)
            {
                return NotFound();
            }

            return rent;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Rent newRent)
        {
            await _rentsService.CreateAsync(newRent);

            return CreatedAtAction(nameof(Get), new { id = newRent.Id }, newRent);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Rent rent)
        {
            var rentToCreate = await _rentsService.GetByIdAsync(id);
            var updatedRent = rent;
            


            if (rentToCreate is null)
            {
                return NotFound();
            }

            updatedRent.Id = rentToCreate.Id;

            await _rentsService.UpdateAsync(id, updatedRent);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var rent = await _rentsService.GetByIdAsync(id);

            if (rent is null)
            {
                return NotFound();
            }

            await _rentsService.DeleteAsync(id);

            return NoContent();
        }
    }
}
