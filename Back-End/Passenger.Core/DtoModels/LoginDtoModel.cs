using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Core.DtoModels
{
    public class LoginDtoModel
    {
        [Required]
        public string UserName { get; set; }

        [Required, MaxLength(16), MinLength(3), DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}
