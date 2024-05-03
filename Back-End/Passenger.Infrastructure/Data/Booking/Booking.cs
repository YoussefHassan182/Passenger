using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Data
{
    public class Booking
    {
        public int Book_Id { get; set; }
        public string Book_Title { get; set; }
        public string Book_Type { get; set; }
        public DateTime Book_Date { get; set; }
        public string Book_Description { get; set; }
        public decimal Book_Price { get; set; }
        public decimal Book_Discount { get; set; }
        public string Book_StartPoint { get; set; }
        public string Book_EndPoint { get; set; }
        public string Book_Status { get; set; }


        public int CustomerID { get; set; } 
        public virtual Customer Customer { get; set; }


    }
}
