using Microsoft.AspNetCore.Identity;
using Passenger.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Core.Interfaces
{
    public interface ICustomerRepository
    {
        public Task<IdentityResult> CreateCustomer(CustomerDtoModel obj);
        public Task<SignInResult> SignInCustomer(LoginDtoModel model);
        public void SignOutCustomer();


    }
}
