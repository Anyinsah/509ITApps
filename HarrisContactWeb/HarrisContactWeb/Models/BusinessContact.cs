using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactWeb.Models
{
    public class BusinessContact
    {
        /* Just like the class PersonalContact in the C# Application
         * We define get; set variables to paramaters that will be used to identify the columns in the table from the database
         */
        public int ID { get; set; }
        public string bName { get; set; }
        public string bEmail { get; set; }
        public string bNumber { get; set; }

    }
}
