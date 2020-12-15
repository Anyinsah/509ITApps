using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisContactManagerCSharp
{
    static class Program
    {
        /// 509IT - C# Application by Josiah Anyinsah-Bondzie
        /// This application establishes a connection to the SQL Database called HarrisContactDb. 
        /// In which allows the user to Create, Read, Update, Delete the contents of the database through this application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ContactMenu());
        }
    }
}
