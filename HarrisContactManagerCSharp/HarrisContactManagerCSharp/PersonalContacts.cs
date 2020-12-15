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

    public class PersonalContacts : Contact // This class inherits the objects from the Contact class
    {
        /* we set get; set; abilities for the strings defined in this class as these will be the paramaters used in order to store items in the 
         * datagridview and pass paramaters through the sql database command methods
         */

        public string pContactTel { get; set; }
        public string pAddress1 { get; set; }
        public string pAddress2 {get; set;}
        public string pCity { get; set; }
        public string aPostCode { get; set; }

    }
}
