namespace ChattBank
{
    partial class AdminHomeForm
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
            this.createCustomerBtn = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createCustomerBtn
            // 
            this.createCustomerBtn.Location = new System.Drawing.Point(339, 143);
            this.createCustomerBtn.Name = "createCustomerBtn";
            this.createCustomerBtn.Size = new System.Drawing.Size(161, 29);
            this.createCustomerBtn.TabIndex = 0;
            this.createCustomerBtn.Text = "Create Customer";
            this.createCustomerBtn.UseVisualStyleBackColor = true;
            this.createCustomerBtn.Click += new System.EventHandler(this.createCustomerBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Location = new System.Drawing.Point(339, 231);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(161, 29);
            this.deleteCustomerBtn.TabIndex = 1;
            this.deleteCustomerBtn.Text = "Delete Customer";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteCustomerBtn);
            this.Controls.Add(this.createCustomerBtn);
            this.Name = "AdminHomeForm";
            this.Text = "AdminHomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button createCustomerBtn;
        private Button deleteCustomerBtn;
    }
}