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
    public partial class PersonalEditor : Form
    {
        DbConn DbConn = new DbConn();
        public PersonalEditor()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PersonalEditor_Load(object sender, EventArgs e)
        {
            pContactsDataGrid.DataSource = DbConn.getPContacts();
        }

        private void pContactsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
          

        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            SaveNewButton.Enabled = true;
            addNewButton.Enabled = false;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            fname_Textbox.Enabled = true;
            sname_Textbox.Enabled = true;
            cemail_Textbox.Enabled = true;
            cnumber_Textbox.Enabled = true;
            pnumber_Textbox.Enabled = true;
            fAddress_Textbox.Enabled = true;
            sAddress_Textbox.Enabled = true;
            city_Textbox.Enabled = true;
            postcode_Textbox.Enabled = true;
        }

        private void pContactsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Int32.Parse(pContactsDataGrid.SelectedCells[0].Value.ToString());
            fname_Textbox.Text = pContactsDataGrid.SelectedCells[1].Value.ToString();
            sname_Textbox.Text = pContactsDataGrid.SelectedCells[2].Value.ToString();
            cemail_Textbox.Text = pContactsDataGrid.SelectedCells[3].Value.ToString();
            cnumber_Textbox.Text = pContactsDataGrid.SelectedCells[4].Value.ToString();
            pnumber_Textbox.Text = pContactsDataGrid.SelectedCells[5].Value.ToString();
            fAddress_Textbox.Text = pContactsDataGrid.SelectedCells[6].Value.ToString();
            sAddress_Textbox.Text = pContactsDataGrid.SelectedCells[7].Value.ToString();
            city_Textbox.Text = pContactsDataGrid.SelectedCells[8].Value.ToString();
            postcode_Textbox.Text = pContactsDataGrid.SelectedCells[9].Value.ToString();

        }

        private void SaveNewButton_Click(object sender, EventArgs e)
        {
            PersonalContacts pContact = new PersonalContacts();
            pContact.cFirstName = fname_Textbox.Text;
            pContact.cSecondName = sname_Textbox.Text;
            pContact.cEmail = cemail_Textbox.Text;
            pContact.cContactTel = cnumber_Textbox.Text;
            pContact.pContactTel = pnumber_Textbox.Text;
            pContact.pAddress1 = fAddress_Textbox.Text;
            pContact.pAddress2 = sAddress_Textbox.Text;
            pContact.pCity = city_Textbox.Text;
            pContact.aPostCode = postcode_Textbox.Text;
            DbConn.insertPContacts(pContact);
            SaveNewButton.Enabled = false;
            addNewButton.Enabled = true;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            fname_Textbox.Enabled = false;
            sname_Textbox.Enabled = false;
            cemail_Textbox.Enabled = false;
            cnumber_Textbox.Enabled = false;
            pnumber_Textbox.Enabled = false;
            fAddress_Textbox.Enabled = false;
            sAddress_Textbox.Enabled = false;
            city_Textbox.Enabled = false;
            postcode_Textbox.Enabled = false;
            fname_Textbox.Text = String.Empty;
            sname_Textbox.Text = String.Empty;
            cemail_Textbox.Text = String.Empty;
            cnumber_Textbox.Text = String.Empty;
            pnumber_Textbox.Text = String.Empty;
            fAddress_Textbox.Text = String.Empty;
            sAddress_Textbox.Text = String.Empty;
            city_Textbox.Text = String.Empty;
            postcode_Textbox.Text = String.Empty;
            pContactsDataGrid.DataSource = DbConn.getPContacts();



        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            pContactsDataGrid.DataSource = DbConn.getPContacts();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            saveSelectedButton.Enabled = true;
            addNewButton.Enabled = false;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            fname_Textbox.Enabled = true;
            sname_Textbox.Enabled = true;
            cemail_Textbox.Enabled = true;
            cnumber_Textbox.Enabled = true;
            pnumber_Textbox.Enabled = true;
            fAddress_Textbox.Enabled = true;
            sAddress_Textbox.Enabled = true;
            city_Textbox.Enabled = true;
            postcode_Textbox.Enabled = true;
        }

        private void saveSelectedButton_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(pContactsDataGrid.SelectedCells[0].Value.ToString());
            PersonalContacts pContact = new PersonalContacts();
            pContact.ContactID = index;
            pContact.cFirstName = fname_Textbox.Text;
            pContact.cSecondName = sname_Textbox.Text;
            pContact.cEmail = cemail_Textbox.Text;
            pContact.cContactTel = cnumber_Textbox.Text;
            pContact.pContactTel = pnumber_Textbox.Text;
            pContact.pAddress1 = fAddress_Textbox.Text;
            pContact.pAddress2 = sAddress_Textbox.Text;
            pContact.pCity = city_Textbox.Text;
            pContact.aPostCode = postcode_Textbox.Text;
            DbConn.updatePContacts(pContact);
            pContactsDataGrid.DataSource = DbConn.getPContacts();
            SaveNewButton.Enabled = false;
            saveSelectedButton.Enabled = false;
            addNewButton.Enabled = true;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            fname_Textbox.Enabled = false;
            sname_Textbox.Enabled = false;
            cemail_Textbox.Enabled = false;
            cnumber_Textbox.Enabled = false;
            pnumber_Textbox.Enabled = false;
            fAddress_Textbox.Enabled = false;
            sAddress_Textbox.Enabled = false;
            city_Textbox.Enabled = false;
            postcode_Textbox.Enabled = false;
            fname_Textbox.Text = String.Empty;
            sname_Textbox.Text = String.Empty;
            cemail_Textbox.Text = String.Empty;
            cnumber_Textbox.Text = String.Empty;
            pnumber_Textbox.Text = String.Empty;
            fAddress_Textbox.Text = String.Empty;
            sAddress_Textbox.Text = String.Empty;
            city_Textbox.Text = String.Empty;
            postcode_Textbox.Text = String.Empty;


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this row?";
            string caption = "Are you sure you want to delete row with ID:" + Int32.Parse(pContactsDataGrid.SelectedCells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                DbConn.deletePContacts(Int32.Parse(pContactsDataGrid.SelectedCells[0].Value.ToString()));
                pContactsDataGrid.DataSource = DbConn.getPContacts();
            }

        }

        private void pContactsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
