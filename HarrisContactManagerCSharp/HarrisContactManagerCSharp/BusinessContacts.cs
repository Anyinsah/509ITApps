using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisContactManagerCSharp
{
    public class BusinessContacts : Contact
    {
        public int BusinessID { get; set; }
        public string bName { get; set; }
        public string bEmail { get; set; }
        public string bNumber { get; set; }

    }
}
