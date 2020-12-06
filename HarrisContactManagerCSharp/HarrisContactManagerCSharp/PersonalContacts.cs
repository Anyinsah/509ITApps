using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisContactManagerCSharp
{
    public class PersonalContacts : Contact
    {
        public int pContactTel { get; set; }
        public string pAddress1 { get; set; }
        public string pAddress2 {get; set;}
        public string pCity { get; set; }
        public string aPostCode { get; set; }

    }
}
