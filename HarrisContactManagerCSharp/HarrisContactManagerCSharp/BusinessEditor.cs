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
    public partial class BusinessEditor : Form
    {
        DbConn DbConn = new DbConn();
        public BusinessEditor()
        {
            InitializeComponent();
        }

        private void BusinessEditor_Load(object sender, EventArgs e)
        {
            bContactsDataGrid.DataSource = DbConn.getBContacts();
        }

        private void bContactsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = Int32.Parse(bContactsDataGrid.SelectedCells[0].Value.ToString());
            bName_Textbox.Text = bContactsDataGrid.SelectedCells[1].Value.ToString();
            bEmail_Textbox.Text = bContactsDataGrid.SelectedCells[2].Value.ToString();
            bNumber_Textbox.Text = bContactsDataGrid.SelectedCells[3].Value.ToString();
            btnUpdateSelected.Enabled = true;
            btnDeleteSelected.Enabled = true;

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
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
            BusinessContacts businessContacts = new BusinessContacts();
            businessContacts.bName = bName_Textbox.Text;
            businessContacts.bEmail = bEmail_Textbox.Text;
            businessContacts.bNumber = bNumber_Textbox.Text;
            DbConn.insertBContacts(businessContacts);
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
            bContactsDataGrid.DataSource = DbConn.getBContacts();

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
            businessContacts.BusinessID = index;
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
            string message = "Are you sure you want to delete this row?";
            string caption = "Are you sure you want to delete this row with ID: " + Int32.Parse(bContactsDataGrid.SelectedCells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                DbConn.deleteBContacts(Int32.Parse(bContactsDataGrid.SelectedCells[0].Value.ToString()));
                bContactsDataGrid.DataSource = DbConn.getBContacts();

            }
        }
    }
}
