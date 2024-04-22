namespace ChattBank
{
    partial class CustomerHomeForm
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
            this.idLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.viewAccountsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(314, 60);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(27, 20);
            this.idLbl.TabIndex = 0;
            this.idLbl.Text = "ID:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(268, 91);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(73, 20);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Password:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(259, 127);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(83, 20);
            this.firstNameLbl.TabIndex = 2;
            this.firstNameLbl.Text = "First Name:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(259, 165);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(82, 20);
            this.lastNameLbl.TabIndex = 3;
            this.lastNameLbl.Text = "Last Name:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(276, 200);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(65, 20);
            this.addressLbl.TabIndex = 4;
            this.addressLbl.Text = "Address:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(292, 238);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(49, 20);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email:";
            // 
            // viewAccountsBtn
            // 
            this.viewAccountsBtn.Location = new System.Drawing.Point(292, 334);
            this.viewAccountsBtn.Name = "viewAccountsBtn";
            this.viewAccountsBtn.Size = new System.Drawing.Size(225, 29);
            this.viewAccountsBtn.TabIndex = 6;
            this.viewAccountsBtn.Text = "View Accounts";
            this.viewAccountsBtn.UseVisualStyleBackColor = true;
            this.viewAccountsBtn.Click += new System.EventHandler(this.viewAccountsBtn_Click);
            // 
            // CustomerHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewAccountsBtn);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.idLbl);
            this.Name = "CustomerHomeForm";
            this.Text = "CustomerHomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label idLbl;
        private Label passwordLbl;
        private Label firstNameLbl;
        private Label lastNameLbl;
        private Label addressLbl;
        private Label emailLbl;
        private Button viewAccountsBtn;
    }
}