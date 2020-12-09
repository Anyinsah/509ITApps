
namespace HarrisContactManagerCSharp
{
    partial class BusinessEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.mySqlDataAdapter2 = new MySqlConnector.MySqlDataAdapter();
            this.bContactsDataGrid = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.bname_label = new System.Windows.Forms.Label();
            this.bemail_label = new System.Windows.Forms.Label();
            this.bnumber_label = new System.Windows.Forms.Label();
            this.bName_Textbox = new System.Windows.Forms.TextBox();
            this.bEmail_Textbox = new System.Windows.Forms.TextBox();
            this.bNumber_Textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bContactsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlDataAdapter2
            // 
            this.mySqlDataAdapter2.DeleteCommand = null;
            this.mySqlDataAdapter2.InsertCommand = null;
            this.mySqlDataAdapter2.SelectCommand = null;
            this.mySqlDataAdapter2.UpdateBatchSize = 0;
            this.mySqlDataAdapter2.UpdateCommand = null;
            // 
            // bContactsDataGrid
            // 
            this.bContactsDataGrid.AllowUserToResizeColumns = false;
            this.bContactsDataGrid.AllowUserToResizeRows = false;
            this.bContactsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bContactsDataGrid.Location = new System.Drawing.Point(12, 122);
            this.bContactsDataGrid.Name = "bContactsDataGrid";
            this.bContactsDataGrid.ReadOnly = true;
            this.bContactsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bContactsDataGrid.Size = new System.Drawing.Size(449, 150);
            this.bContactsDataGrid.TabIndex = 0;
            this.bContactsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bContactsDataGrid_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(386, 93);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Location = new System.Drawing.Point(386, 39);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 2;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(386, 10);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.Enabled = false;
            this.btnUpdateSelected.Location = new System.Drawing.Point(257, 10);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateSelected.TabIndex = 4;
            this.btnUpdateSelected.Text = "Update Selected";
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Enabled = false;
            this.btnDeleteSelected.Location = new System.Drawing.Point(257, 68);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(123, 23);
            this.btnDeleteSelected.TabIndex = 5;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Enabled = false;
            this.btnSaveSelected.Location = new System.Drawing.Point(257, 39);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(123, 23);
            this.btnSaveSelected.TabIndex = 6;
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // bname_label
            // 
            this.bname_label.AutoSize = true;
            this.bname_label.Location = new System.Drawing.Point(21, 15);
            this.bname_label.Name = "bname_label";
            this.bname_label.Size = new System.Drawing.Size(80, 13);
            this.bname_label.TabIndex = 7;
            this.bname_label.Text = "Business Name";
            // 
            // bemail_label
            // 
            this.bemail_label.AutoSize = true;
            this.bemail_label.Location = new System.Drawing.Point(21, 42);
            this.bemail_label.Name = "bemail_label";
            this.bemail_label.Size = new System.Drawing.Size(77, 13);
            this.bemail_label.TabIndex = 8;
            this.bemail_label.Text = "Business Email";
            // 
            // bnumber_label
            // 
            this.bnumber_label.AutoSize = true;
            this.bnumber_label.Location = new System.Drawing.Point(21, 73);
            this.bnumber_label.Name = "bnumber_label";
            this.bnumber_label.Size = new System.Drawing.Size(89, 13);
            this.bnumber_label.TabIndex = 9;
            this.bnumber_label.Text = "Business Number";
            // 
            // bName_Textbox
            // 
            this.bName_Textbox.Enabled = false;
            this.bName_Textbox.Location = new System.Drawing.Point(126, 12);
            this.bName_Textbox.Name = "bName_Textbox";
            this.bName_Textbox.Size = new System.Drawing.Size(100, 20);
            this.bName_Textbox.TabIndex = 10;
            // 
            // bEmail_Textbox
            // 
            this.bEmail_Textbox.Enabled = false;
            this.bEmail_Textbox.Location = new System.Drawing.Point(126, 39);
            this.bEmail_Textbox.Name = "bEmail_Textbox";
            this.bEmail_Textbox.Size = new System.Drawing.Size(100, 20);
            this.bEmail_Textbox.TabIndex = 11;
            // 
            // bNumber_Textbox
            // 
            this.bNumber_Textbox.Enabled = false;
            this.bNumber_Textbox.Location = new System.Drawing.Point(126, 68);
            this.bNumber_Textbox.Name = "bNumber_Textbox";
            this.bNumber_Textbox.Size = new System.Drawing.Size(100, 20);
            this.bNumber_Textbox.TabIndex = 12;
            // 
            // BusinessEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 284);
            this.Controls.Add(this.bNumber_Textbox);
            this.Controls.Add(this.bEmail_Textbox);
            this.Controls.Add(this.bName_Textbox);
            this.Controls.Add(this.bnumber_label);
            this.Controls.Add(this.bemail_label);
            this.Controls.Add(this.bname_label);
            this.Controls.Add(this.btnSaveSelected);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnUpdateSelected);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.bContactsDataGrid);
            this.Name = "BusinessEditor";
            this.Text = "Business Contact Editor";
            this.Load += new System.EventHandler(this.BusinessEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bContactsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter2;
        private System.Windows.Forms.DataGridView bContactsDataGrid;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.Label bname_label;
        private System.Windows.Forms.Label bemail_label;
        private System.Windows.Forms.Label bnumber_label;
        private System.Windows.Forms.TextBox bName_Textbox;
        private System.Windows.Forms.TextBox bEmail_Textbox;
        private System.Windows.Forms.TextBox bNumber_Textbox;
    }
}