using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passenger.Infrastructure.Data;

namespace Passenger.Infrastructure.Data
{
    public class Customer
    {
        public int Cus_Id { get; set; }

        public string Cus_Name { get; set; }
        public int Cus_Phone { get; set; }
        public string Cus_Email { get; set; }
        public string Cus_Password { get; set; }

        public int CityZipCode { get; set; } 
        public virtual City City { get; set;}
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }

    }
}
