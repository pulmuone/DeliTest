using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest.Models.DeliveryArea
{
    public class DeliveryAreaResponseModel
    {
        public string Zipcode { get; set;}
        public List<string> Branchs { get; set; }
    }
}
