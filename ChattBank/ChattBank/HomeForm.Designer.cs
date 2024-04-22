namespace ChattBank
{
    partial class HomeForm
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
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.customerLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.Location = new System.Drawing.Point(328, 259);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(149, 29);
            this.adminLoginBtn.TabIndex = 0;
            this.adminLoginBtn.Text = "Admin Login";
            this.adminLoginBtn.UseVisualStyleBackColor = true;
            this.adminLoginBtn.Click += new System.EventHandler(this.adminLoginBtn_Click);
            // 
            // customerLoginBtn
            // 
            this.customerLoginBtn.Location = new System.Drawing.Point(328, 142);
            this.customerLoginBtn.Name = "customerLoginBtn";
            this.customerLoginBtn.Size = new System.Drawing.Size(149, 29);
            this.customerLoginBtn.TabIndex = 1;
            this.customerLoginBtn.Text = "Customer Login";
            this.customerLoginBtn.UseVisualStyleBackColor = true;
            this.customerLoginBtn.Click += new System.EventHandler(this.customerLoginBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerLoginBtn);
            this.Controls.Add(this.adminLoginBtn);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button adminLoginBtn;
        private Button customerLoginBtn;
    }
}