using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisContactManagerCSharp
{
    /* CODE COMMENTED BY JOSIAH ANYINSAH-BONDZIE
     * ANY DUPLICATIVE/SIMILAR CODE WILL NOT BE COMMONTED ON AFTERWARDS. 
     */

    public class Contact
    /* we set get; set; abilities for the strings defined in this class as these will be the paramaters used in order to store items in the 
    * datagridview and pass paramaters through the sql database command methods
    */
    {
        public int ContactID { get; set; }
        public String cFirstName { get; set; }
        public String cSecondName { get; set; }
        public String cEmail { get; set; }

        public string cContactTel { get; set; }
 
    }
}
