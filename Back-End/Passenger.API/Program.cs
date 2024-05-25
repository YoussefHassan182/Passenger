using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Passenger.Core.Entities;
using Passenger.Core.Interfaces;
using Passenger.Infrastructure.Data;
using Passenger.Services.Services;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PassengerDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("connectionKey"));
});

builder.Services.AddIdentity<Customer, IdentityRole>()
      .AddEntityFrameworkStores<PassengerDbContext>()
      .AddDefaultTokenProviders();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(i =>
    {
        i.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


//using (var scope = app.Services.CreateScope())
//{
//    var service = scope.ServiceProvider;
//    var loggerFactory = service.GetRequiredService<ILoggerFactory>();
//    var userManager = service.GetRequiredService<UserManager<Customer>>();
//    var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
//    try
//    {
//        //Ensure Database Creation and Update to Latest Migration
//        var context = service.GetRequiredService<PassengerDbContext>();
//        await context.Database.MigrateAsync();
//    }
//    catch (Exception ex)
//    {
//        var logger = loggerFactory.CreateLogger<Program>();
//        logger.LogError(ex, "An Error Ocurred During Migration");
//    }
//}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}






app.UseCors();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
