using API.RenalReviews.Models;
using API.RentalReviews.DatabaseSettings;
using API.RentalReviews.Interfaces;
using API.RentalReviews.Models;
using API.RentalReviews.Views.Review;
using API.RentalReviews.Views.User;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace API.RentalReviews.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IMongoCollection<Rent> _rentsCollection;
        private readonly IMapper _mapper;

        public ReviewService(
            IOptions<RentStoreDatabaseSettings> rentStoreDatabaseSettings, IMapper mapper)
        {
            var mongoClient = new MongoClient(
                rentStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                rentStoreDatabaseSettings.Value.DatabaseName);

            _rentsCollection = mongoDatabase.GetCollection<Rent>(
                rentStoreDatabaseSettings.Value.RentsCollectionName);
            _mapper = mapper;
        }

        public async Task CreateReviewsAsync(string id, List<ReviewPostView> reviewPostViewList)
        {
            var reviewsListToCreate = _mapper.Map<List<Review>>(reviewPostViewList);
            var filter = Builders<Rent>.Filter.Eq(x => x._id, id);
            var update = Builders<Rent>.Update.PushEach(x => x.Reviews, reviewsListToCreate);
            await _rentsCollection.UpdateManyAsync(filter, update);
        }

        public async Task UpdateReviewsAsync(string id, ReviewPutView reviewPutView)
        {
            var reviewsListToUpdate = _mapper.Map<Review>(reviewPutView);

            var rent = new Rent();
            rent.Reviews.Add(reviewsListToUpdate);

            var builder = Builders<Rent>.Filter;
            var filter = builder.Eq(x => x._id, id); 
            var update = Builders<Rent>.Update.AddToSet<Review>
            ("reviews", reviewsListToUpdate);

            await _rentsCollection.UpdateOneAsync(filter, update);
        }
    }
}
