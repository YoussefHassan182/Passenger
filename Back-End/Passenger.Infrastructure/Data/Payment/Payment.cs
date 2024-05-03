using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Data
{
    public class Payment
    {
        public int Pay_Id { get; set; }
        public decimal Pay_Amount { get; set;}
        public DateTime Pay_Date{ get; set;}
        public string Pay_Type { get; set;}
        public string Pay_Currency { get; set;}


        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
