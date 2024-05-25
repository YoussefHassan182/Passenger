using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Passenger.Core.DtoModels;
using Passenger.Core.Entities;
using Passenger.Core.Interfaces;

namespace Passenger.API.Controllers.Customer
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerController(ICustomerRepository _customerRepository)
        {
            customerRepository = _customerRepository;
        }


        

        [HttpPost("SignUp")]
        public async  Task SignUp([FromBody]CustomerDtoModel dtoModel)
        {
            if (ModelState.IsValid == false)
            {
                return;
            }
            IdentityResult result = await customerRepository.CreateCustomer(dtoModel);
            if (result.Succeeded == false)
            {
                result.Errors.ToList().ForEach(i => { ModelState.AddModelError("", i.Description); });
            }
            else
            {
                return;
            }
        }

        [HttpPost("SignIn")]
        public async Task<ResultDtoModel> SignIn([FromBody] LoginDtoModel model)
        {
            ResultDtoModel myModel = new ResultDtoModel();
            if (ModelState.IsValid == false)
            {
                myModel.Success = false;
            }
            else
            {
                var result = await customerRepository.SignInCustomer(model);

                if (result.Succeeded == false)
                {
                    myModel.Success = false;
                    myModel.Message = "Invalid UserName Or Password ";
                }
                else if (result.IsLockedOut == true)
                {
                    myModel.Success = false;
                    myModel.Message = "Is Locked Out";
                }
                else if (result.IsNotAllowed == true)
                {
                    myModel.Success = false;
                    myModel.Message = "Is Not Allowed";
                }
                else if (result.Succeeded == true){
                    myModel.Success=true;
                    myModel.Message = "SignedIn Done";
                }
            }
            return myModel;
        }

        [HttpGet(Name = "SignOut")]
        public new async Task<bool> SignOut()
        {
            customerRepository.SignOutCustomer();
            return true;
        }

    }
}
