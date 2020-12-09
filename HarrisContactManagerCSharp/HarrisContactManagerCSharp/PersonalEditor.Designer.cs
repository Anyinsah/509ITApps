
namespace HarrisContactManagerCSharp
{
    partial class PersonalEditor
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
            this.pContactsDataGrid = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.SaveNewButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveSelectedButton = new System.Windows.Forms.Button();
            this.fname_Textbox = new System.Windows.Forms.TextBox();
            this.fAddress_Textbox = new System.Windows.Forms.TextBox();
            this.sname_Textbox = new System.Windows.Forms.TextBox();
            this.cemail_Textbox = new System.Windows.Forms.TextBox();
            this.cnumber_Textbox = new System.Windows.Forms.TextBox();
            this.pnumber_Textbox = new System.Windows.Forms.TextBox();
            this.sAddress_Textbox = new System.Windows.Forms.TextBox();
            this.city_Textbox = new System.Windows.Forms.TextBox();
            this.postcode_Textbox = new System.Windows.Forms.TextBox();
            this.fname_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.cnumber_label = new System.Windows.Forms.Label();
            this.pnumber_label = new System.Windows.Forms.Label();
            this.faddress_label = new System.Windows.Forms.Label();
            this.saddress_label = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.pcode_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pContactsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pContactsDataGrid
            // 
            this.pContactsDataGrid.AllowUserToResizeColumns = false;
            this.pContactsDataGrid.AllowUserToResizeRows = false;
            this.pContactsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pContactsDataGrid.Location = new System.Drawing.Point(12, 155);
            this.pContactsDataGrid.Name = "pContactsDataGrid";
            this.pContactsDataGrid.ReadOnly = true;
            this.pContactsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pContactsDataGrid.Size = new System.Drawing.Size(776, 283);
            this.pContactsDataGrid.TabIndex = 0;
            this.pContactsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pContactsDataGrid_CellClick);
            this.pContactsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pContactsDataGrid_CellContentClick);
            this.pContactsDataGrid.SelectionChanged += new System.EventHandler(this.pContactsDataGrid_SelectionChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(713, 126);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(713, 12);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(75, 23);
            this.addNewButton.TabIndex = 2;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // SaveNewButton
            // 
            this.SaveNewButton.Enabled = false;
            this.SaveNewButton.Location = new System.Drawing.Point(713, 42);
            this.SaveNewButton.Name = "SaveNewButton";
            this.SaveNewButton.Size = new System.Drawing.Size(75, 23);
            this.SaveNewButton.TabIndex = 3;
            this.SaveNewButton.Text = "Save New";
            this.SaveNewButton.UseVisualStyleBackColor = true;
            this.SaveNewButton.Click += new System.EventHandler(this.SaveNewButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(589, 12);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(118, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update Selected";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(589, 71);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete Selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveSelectedButton
            // 
            this.saveSelectedButton.Enabled = false;
            this.saveSelectedButton.Location = new System.Drawing.Point(589, 42);
            this.saveSelectedButton.Name = "saveSelectedButton";
            this.saveSelectedButton.Size = new System.Drawing.Size(118, 23);
            this.saveSelectedButton.TabIndex = 6;
            this.saveSelectedButton.Text = "Save Selected";
            this.saveSelectedButton.UseVisualStyleBackColor = true;
            this.saveSelectedButton.Click += new System.EventHandler(this.saveSelectedButton_Click);
            // 
            // fname_Textbox
            // 
            this.fname_Textbox.Enabled = false;
            this.fname_Textbox.Location = new System.Drawing.Point(72, 42);
            this.fname_Textbox.Name = "fname_Textbox";
            this.fname_Textbox.Size = new System.Drawing.Size(100, 20);
            this.fname_Textbox.TabIndex = 8;
            this.fname_Textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fAddress_Textbox
            // 
            this.fAddress_Textbox.Enabled = false;
            this.fAddress_Textbox.Location = new System.Drawing.Point(282, 104);
            this.fAddress_Textbox.Name = "fAddress_Textbox";
            this.fAddress_Textbox.Size = new System.Drawing.Size(100, 20);
            this.fAddress_Textbox.TabIndex = 9;
            // 
            // sname_Textbox
            // 
            this.sname_Textbox.Enabled = false;
            this.sname_Textbox.Location = new System.Drawing.Point(72, 74);
            this.sname_Textbox.Name = "sname_Textbox";
            this.sname_Textbox.Size = new System.Drawing.Size(100, 20);
            this.sname_Textbox.TabIndex = 10;
            // 
            // cemail_Textbox
            // 
            this.cemail_Textbox.Enabled = false;
            this.cemail_Textbox.Location = new System.Drawing.Point(72, 104);
            this.cemail_Textbox.Name = "cemail_Textbox";
            this.cemail_Textbox.Size = new System.Drawing.Size(100, 20);
            this.cemail_Textbox.TabIndex = 11;
            // 
            // cnumber_Textbox
            // 
            this.cnumber_Textbox.Enabled = false;
            this.cnumber_Textbox.Location = new System.Drawing.Point(282, 42);
            this.cnumber_Textbox.Name = "cnumber_Textbox";
            this.cnumber_Textbox.Size = new System.Drawing.Size(100, 20);
            this.cnumber_Textbox.TabIndex = 12;
            // 
            // pnumber_Textbox
            // 
            this.pnumber_Textbox.Enabled = false;
            this.pnumber_Textbox.Location = new System.Drawing.Point(282, 74);
            this.pnumber_Textbox.Name = "pnumber_Textbox";
            this.pnumber_Textbox.Size = new System.Drawing.Size(100, 20);
            this.pnumber_Textbox.TabIndex = 13;
            // 
            // sAddress_Textbox
            // 
            this.sAddress_Textbox.Enabled = false;
            this.sAddress_Textbox.Location = new System.Drawing.Point(463, 42);
            this.sAddress_Textbox.Name = "sAddress_Textbox";
            this.sAddress_Textbox.Size = new System.Drawing.Size(100, 20);
            this.sAddress_Textbox.TabIndex = 14;
            // 
            // city_Textbox
            // 
            this.city_Textbox.Enabled = false;
            this.city_Textbox.Location = new System.Drawing.Point(463, 75);
            this.city_Textbox.Name = "city_Textbox";
            this.city_Textbox.Size = new System.Drawing.Size(100, 20);
            this.city_Textbox.TabIndex = 15;
            // 
            // postcode_Textbox
            // 
            this.postcode_Textbox.Enabled = false;
            this.postcode_Textbox.Location = new System.Drawing.Point(463, 104);
            this.postcode_Textbox.Name = "postcode_Textbox";
            this.postcode_Textbox.Size = new System.Drawing.Size(100, 20);
            this.postcode_Textbox.TabIndex = 16;
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Location = new System.Drawing.Point(10, 45);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(57, 13);
            this.fname_label.TabIndex = 17;
            this.fname_label.Text = "First Name";
            this.fname_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Location = new System.Drawing.Point(9, 78);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(58, 13);
            this.lname_label.TabIndex = 18;
            this.lname_label.Text = "Last Name";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(34, 107);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(32, 13);
            this.email_label.TabIndex = 19;
            this.email_label.Text = "Email";
            // 
            // cnumber_label
            // 
            this.cnumber_label.AutoSize = true;
            this.cnumber_label.Location = new System.Drawing.Point(192, 45);
            this.cnumber_label.Name = "cnumber_label";
            this.cnumber_label.Size = new System.Drawing.Size(84, 13);
            this.cnumber_label.TabIndex = 20;
            this.cnumber_label.Text = "Contact Number";
            // 
            // pnumber_label
            // 
            this.pnumber_label.AutoSize = true;
            this.pnumber_label.Location = new System.Drawing.Point(188, 76);
            this.pnumber_label.Name = "pnumber_label";
            this.pnumber_label.Size = new System.Drawing.Size(88, 13);
            this.pnumber_label.TabIndex = 21;
            this.pnumber_label.Text = "Personal Number";
            // 
            // faddress_label
            // 
            this.faddress_label.AutoSize = true;
            this.faddress_label.Location = new System.Drawing.Point(222, 107);
            this.faddress_label.Name = "faddress_label";
            this.faddress_label.Size = new System.Drawing.Size(54, 13);
            this.faddress_label.TabIndex = 22;
            this.faddress_label.Text = "Address 1";
            // 
            // saddress_label
            // 
            this.saddress_label.AutoSize = true;
            this.saddress_label.Location = new System.Drawing.Point(403, 44);
            this.saddress_label.Name = "saddress_label";
            this.saddress_label.Size = new System.Drawing.Size(54, 13);
            this.saddress_label.TabIndex = 23;
            this.saddress_label.Text = "Address 2";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(433, 78);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(24, 13);
            this.city_label.TabIndex = 24;
            this.city_label.Text = "City";
            // 
            // pcode_label
            // 
            this.pcode_label.AutoSize = true;
            this.pcode_label.Location = new System.Drawing.Point(403, 107);
            this.pcode_label.Name = "pcode_label";
            this.pcode_label.Size = new System.Drawing.Size(56, 13);
            this.pcode_label.TabIndex = 25;
            this.pcode_label.Text = "Post Code";
            // 
            // PersonalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcode_label);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.saddress_label);
            this.Controls.Add(this.faddress_label);
            this.Controls.Add(this.pnumber_label);
            this.Controls.Add(this.cnumber_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.postcode_Textbox);
            this.Controls.Add(this.city_Textbox);
            this.Controls.Add(this.sAddress_Textbox);
            this.Controls.Add(this.pnumber_Textbox);
            this.Controls.Add(this.cnumber_Textbox);
            this.Controls.Add(this.cemail_Textbox);
            this.Controls.Add(this.sname_Textbox);
            this.Controls.Add(this.fAddress_Textbox);
            this.Controls.Add(this.fname_Textbox);
            this.Controls.Add(this.saveSelectedButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.SaveNewButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.pContactsDataGrid);
            this.Name = "PersonalEditor";
            this.Text = "Personal Contact Editor";
            this.Load += new System.EventHandler(this.PersonalEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pContactsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pContactsDataGrid;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button SaveNewButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveSelectedButton;
        private System.Windows.Forms.TextBox fname_Textbox;
        private System.Windows.Forms.TextBox fAddress_Textbox;
        private System.Windows.Forms.TextBox sname_Textbox;
        private System.Windows.Forms.TextBox cemail_Textbox;
        private System.Windows.Forms.TextBox cnumber_Textbox;
        private System.Windows.Forms.TextBox pnumber_Textbox;
        private System.Windows.Forms.TextBox sAddress_Textbox;
        private System.Windows.Forms.TextBox city_Textbox;
        private System.Windows.Forms.TextBox postcode_Textbox;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label cnumber_label;
        private System.Windows.Forms.Label pnumber_label;
        private System.Windows.Forms.Label faddress_label;
        private System.Windows.Forms.Label saddress_label;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.Label pcode_label;
    }
}