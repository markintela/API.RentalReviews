using EntityData.DatabaseSettings;
using EntityData.Interfaces;
using EntityData.Repository;
using EntityData.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using ServicesDomain.Interfaces;
using ServicesDomain.Mappers;
using ServicesDomain.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var database = builder.Configuration.GetConnectionString("SqlConnection");
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Database services
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(database);
});


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRentService, RentService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();



builder.Services.AddAutoMapper(typeof(UserProfile));

builder.Services.AddSwaggerGen(opts =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    opts.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});


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
