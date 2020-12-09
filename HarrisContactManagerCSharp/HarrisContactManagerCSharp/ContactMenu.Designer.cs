
namespace HarrisContactManagerCSharp
{
    partial class ContactMenu
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
            this.pContactsButton = new System.Windows.Forms.Button();
            this.bContactsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pContactsButton
            // 
            this.pContactsButton.Location = new System.Drawing.Point(53, 72);
            this.pContactsButton.Name = "pContactsButton";
            this.pContactsButton.Size = new System.Drawing.Size(130, 39);
            this.pContactsButton.TabIndex = 0;
            this.pContactsButton.Text = "Personal Contacts";
            this.pContactsButton.UseVisualStyleBackColor = true;
            this.pContactsButton.Click += new System.EventHandler(this.pContactsButton_Click);
            // 
            // bContactsButton
            // 
            this.bContactsButton.Location = new System.Drawing.Point(225, 72);
            this.bContactsButton.Name = "bContactsButton";
            this.bContactsButton.Size = new System.Drawing.Size(135, 39);
            this.bContactsButton.TabIndex = 1;
            this.bContactsButton.Text = "Business Contacts";
            this.bContactsButton.UseVisualStyleBackColor = true;
            this.bContactsButton.Click += new System.EventHandler(this.bContactsButton_Click);
            // 
            // ContactMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 198);
            this.Controls.Add(this.bContactsButton);
            this.Controls.Add(this.pContactsButton);
            this.Name = "ContactMenu";
            this.Text = "Harris & Sons Contact Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pContactsButton;
        private System.Windows.Forms.Button bContactsButton;
    }
}

