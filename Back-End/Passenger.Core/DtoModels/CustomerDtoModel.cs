using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Core.DtoModels
{
    public class CustomerDtoModel
    {
        [Required, MaxLength(200), MinLength(3)]
        public string FirstName { get; set; }

        [Required, MaxLength(200), MinLength(3)]
        public string LastName { get; set; }
        
        [Required, MaxLength(15), MinLength(3)]
        public string UserName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        [Required, MinLength(6), MaxLength(16), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, Compare("Password"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
