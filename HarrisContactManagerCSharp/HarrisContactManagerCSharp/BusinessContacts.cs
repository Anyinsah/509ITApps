using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisContactManagerCSharp
{
    /* CODE COMMENTED BY JOSIAH ANYINSAH0BONDZIE 
    * ANDY DUPLICATIVE/SIMILAR CODE WILL NOT BE COMMENTED ON AFTERWARDS
    */
    public class BusinessContacts : Contact // This class inherits the objects from the Contact class
    {
        /* we set get; set; abilities for the strings defined in this class as these will be the paramaters used in order to store items in the 
        * datagridview and pass paramaters through the sql database command methods
           */
        public int BusinessID { get; set; }
        public string bName { get; set; }
        public string bEmail { get; set; }
        public string bNumber { get; set; }

    }
}
