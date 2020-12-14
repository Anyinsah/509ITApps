using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactWeb.Models
{
    public class PersonalContact
    {
        public int ID { get; set; }
        public string pFirstName { get; set; }
        public string pLastName { get; set; }
        public string cEmail { get; set; }
        public string cNumber { get; set; }
        public string pNumber { get; set; }
        public string fAddress { get; set; }
        public string sAddress { get; set; }
        public string pCity { get; set; }
        public string personalPostCode { get; set; }


    }
}
