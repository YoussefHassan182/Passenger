using Microsoft.AspNetCore.Identity;
using Passenger.Core.DtoModels;
using Passenger.Core.Entities;
using Passenger.Core.Interfaces;
using Passenger.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Services.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly PassengerDbContext passengerDb;
        private readonly SignInManager<Customer> signInManager;
        private readonly UserManager<Customer> userManager;

        public CustomerRepository(PassengerDbContext passengerDb ,SignInManager<Customer> signInManager,UserManager<Customer> userManager ) 
        {
            this.passengerDb = passengerDb;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }


        public async Task<IdentityResult> CreateCustomer(CustomerDtoModel obj)
        {
            Customer user = new Customer()
            {
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                UserName = obj.UserName,
                Email = obj.Email,
                
                PhoneNumber = obj.PhoneNumber,

            };
            IdentityResult result = await userManager.CreateAsync(user, obj.Password);
            return result;
        }


        public async Task<SignInResult> SignInCustomer (LoginDtoModel login)
        {
            return await signInManager.PasswordSignInAsync(login.UserName, login.Password,login.RememberMe ,true);
        }
        public async void SignOutCustomer()
        {
            await signInManager.SignOutAsync();
        }
    }
}
