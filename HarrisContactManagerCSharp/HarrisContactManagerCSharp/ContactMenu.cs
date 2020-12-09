using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisContactManagerCSharp
{
    public partial class ContactMenu : Form
    {
        public ContactMenu()
        {
            InitializeComponent();
        }

        private void pContactsButton_Click(object sender, EventArgs e)
        {
            ContactMenu cMenu = new ContactMenu();
            PersonalEditor pEditor = new PersonalEditor();
            pEditor.Show();
            cMenu.Close();
        }

        private void bContactsButton_Click(object sender, EventArgs e)
        {
            ContactMenu cMenu = new ContactMenu();
            BusinessEditor bEditor = new BusinessEditor();
            bEditor.Show();
            cMenu.Close();
        }
    }
}
