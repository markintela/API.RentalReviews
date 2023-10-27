using API.RenalReviews.Models;
using API.RenalReviews.Services;
using API.RentalReviews.Interfaces;
using API.RentalReviews.Models;
using API.RentalReviews.Services;
using API.RentalReviews.Views.Rent;
using API.RentalReviews.Views.User;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.RentalReviews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {

        private readonly RentService _rentsService;
        private readonly IMapper _mapper;

        public RentController(RentService rentsService, IMapper mapper)
        {
            _rentsService = rentsService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<List<Rent>> Get() =>
            await _rentsService.GetAllAsync();

        [HttpGet("{id:length(36)}")]
        public async Task<ActionResult<Rent>> GetById(string id)
        {


            var user = new User() { Nome = "marcus" };


            var rent = await _rentsService.GetByIdAsync(id);

            if (rent is null)
            {
                return NotFound();
            }

            return rent;
        }

        [HttpPost]
        public async Task<IActionResult> Post(RentPostView rentPostView)
        {


            var rent = _mapper.Map<Rent>(rentPostView);

            await _rentsService.CreateAsync(rent);

            return CreatedAtAction(nameof(Get), new { id = rent._id }, rent);
        }

        [HttpPut("Update", Name = "Update")]
        public async Task<IActionResult> Update(string id, Rent rent)
        {
            var rentToCreate = await _rentsService.GetByIdAsync(id);
            var updatedRent = rent;



            if (rentToCreate is null)
            {
                return NotFound();
            }

            updatedRent._id = rentToCreate._id;

            await _rentsService.UpdateAsync(id, updatedRent);

            return NoContent();
        }

        [HttpDelete("{id:length(36)}")]
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
