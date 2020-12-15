using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * CODE COMMENTED BY JOSIAH ANYINSAH-BONDZIE
 * ANY DUPLICATIVE CODE WILL NOT BE COMMENTED. 
 */

namespace HarrisContactManagerCSharp
{
    public partial class BusinessEditor : Form 
    {
        DbConn DbConn = new DbConn(); // Establish an object to access DbConn Methods
        public BusinessEditor()
        {
            InitializeComponent(); 
        }

        private void BusinessEditor_Load(object sender, EventArgs e)
        {
            bContactsDataGrid.DataSource = DbConn.getBContacts();
        }

        private void bContactsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e) // When a cell is clicked in the datagridview
        {

            int index = Int32.Parse(bContactsDataGrid.SelectedCells[0].Value.ToString()); /* Variable called index I set to be the first cell in the row of the selected row. (selected grid)
                                                                                           * The block of code below sets the contents of teh selected cells to the textfield in the textboxes.
                                                                                           * 
                                                                                           */
            bName_Textbox.Text = bContactsDataGrid.SelectedCells[1].Value.ToString();
            bEmail_Textbox.Text = bContactsDataGrid.SelectedCells[2].Value.ToString();
            bNumber_Textbox.Text = bContactsDataGrid.SelectedCells[3].Value.ToString();
            btnUpdateSelected.Enabled = true; //update button becomes enabled again
            btnDeleteSelected.Enabled = true;// delete selected button becomes enabled again

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            // Sets the properties of each textbox and textfield to either true or false.
            //Clears the textfield of the textboxes when this button is clicked

            btnAddNew.Enabled = false;
            btnDeleteSelected.Enabled = false;
            btnSaveSelected.Enabled = false;
            btnSaveSelected.Enabled = false;
            btnSaveNew.Enabled = true;
            bName_Textbox.Enabled = true;
            bEmail_Textbox.Enabled = true;
            bNumber_Textbox.Enabled = true;
            bName_Textbox.Text = String.Empty;
            bEmail_Textbox.Text = String.Empty;
            bNumber_Textbox.Text = String.Empty;

        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            /*
             * This block of code represents the 
             *  
             */
            BusinessContacts businessContacts = new BusinessContacts();
            businessContacts.bName = bName_Textbox.Text;
            businessContacts.bEmail = bEmail_Textbox.Text;
            businessContacts.bNumber = bNumber_Textbox.Text;
            DbConn.insertBContacts(businessContacts); /* calls the method insertbContacts from dbconn, passing the parameter businessContacts so that the textbox text can be stored
                                                       * into the database 
                                                       */
            btnAddNew.Enabled = true;
            btnDeleteSelected.Enabled = true;
            btnSaveSelected.Enabled = true;
            btnSaveSelected.Enabled = true;
            btnSaveNew.Enabled = false;
            bName_Textbox.Enabled = false;
            bEmail_Textbox.Enabled = false;
            bNumber_Textbox.Enabled = false;
            bName_Textbox.Text = String.Empty;
            bEmail_Textbox.Text = String.Empty;
            bNumber_Textbox.Text = String.Empty;
            bContactsDataGrid.DataSource = DbConn.getBContacts(); // refresh the datagridtable by recalling the getbContacts method from dbconn.

        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = false;
            btnDeleteSelected.Enabled = false;
            btnSaveSelected.Enabled = true;
            btnUpdateSelected.Enabled = false;
            btnSaveNew.Enabled = false;
            bName_Textbox.Enabled = true;
            bEmail_Textbox.Enabled = true;
            bNumber_Textbox.Enabled = true;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bContactsDataGrid.DataSource = DbConn.getBContacts();
        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(bContactsDataGrid.SelectedCells[0].Value.ToString());
            BusinessContacts businessContacts = new BusinessContacts();
            businessContacts.BusinessID = index; // id set to index so that relative row can be updated given the id matches the information in the table
            businessContacts.bName = bName_Textbox.Text;
            businessContacts.bEmail = bEmail_Textbox.Text;
            businessContacts.bNumber = bNumber_Textbox.Text;
            DbConn.updateBContacts(businessContacts);
            bContactsDataGrid.DataSource = DbConn.getBContacts();
            btnAddNew.Enabled = true;
            btnDeleteSelected.Enabled = true;
            btnSaveSelected.Enabled = false;
            btnUpdateSelected.Enabled = true;
            btnSaveNew.Enabled = false;
            bName_Textbox.Enabled = false;
            bEmail_Textbox.Enabled = false;
            bNumber_Textbox.Enabled = false;
            bName_Textbox.Text = String.Empty;
            bEmail_Textbox.Text = String.Empty;
            bNumber_Textbox.Text = String.Empty;

        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            /*
             * The difference between this code and the previous two is that only the id is called through the deletebContacts metod
             */
            string message = "Are you sure you want to delete this row?"; // message to alert user if they really want to delete the row
            string caption = "Are you sure you want to delete this row with ID: " + Int32.Parse(bContactsDataGrid.SelectedCells[0].Value.ToString()); // shows user the caption with the selected row with its relative ID
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; // messagebox created
            DialogResult result; // dialog result variable result declared
            result = MessageBox.Show(message, caption, buttons); // we pass the message caption and buttons into the mesagebox
            if (result == DialogResult.Yes) // if the button yes is pressed
            {
                DbConn.deleteBContacts(Int32.Parse(bContactsDataGrid.SelectedCells[0].Value.ToString())); // delete corrosponding row with selected id
                bContactsDataGrid.DataSource = DbConn.getBContacts(); //refresh database

            }
        }
    }
}
