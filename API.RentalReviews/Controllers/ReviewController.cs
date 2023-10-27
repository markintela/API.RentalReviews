using API.RentalReviews.Services;
using API.RentalReviews.Views.Review;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.RentalReviews.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ReviewService _reviewService;
        private readonly RentService _rentsService;
        private readonly IMapper _mapper;

        public ReviewController(ReviewService reviewService, RentService rentsService, IMapper mapper)
        {
            _reviewService = reviewService;
            _rentsService = rentsService;
            _mapper = mapper;
        }

        [HttpPost("CreateReview", Name = "CreateReview")]
        public async Task<IActionResult> CreateReview(string id, List<ReviewPostView> reviewPostView)
        {
            var rent = await _rentsService.GetByIdAsync(id);

            if (rent is null)
            {
                return NotFound();
            }

            await _reviewService.CreateReviewsAsync(id, reviewPostView);

            return NoContent();
        }

        [HttpPut("UpdateReview", Name = "UpdateReview")]
        public async Task<IActionResult> UpdateReview(string id, ReviewPutView reviewPutView)
        {
            var rent = await _rentsService.GetByIdAsync(id);

            if (rent is null)
            {
                return NotFound();
            }

            await _reviewService.UpdateReviewsAsync(id,reviewPutView);

            return NoContent();
        }
    }
}
