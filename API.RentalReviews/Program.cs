using API.RenalReviews.Services;
using API.RentalReviews.DatabaseSettings;
using API.RentalReviews.Mappers;
using API.RentalReviews.Services;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//collections configs
builder.Services.Configure<UserStoreDatabaseSettings>(
builder.Configuration.GetSection("UserStoreDatabase"));

builder.Services.Configure<RentStoreDatabaseSettings>(
builder.Configuration.GetSection("RentStoreDatabase"));

builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<RentService>();

builder.Services.AddAutoMapper(typeof(UserProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
