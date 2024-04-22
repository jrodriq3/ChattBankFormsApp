namespace ChattBank
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testAccountBtn = new System.Windows.Forms.Button();
            this.testCustomerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testAccountBtn
            // 
            this.testAccountBtn.Location = new System.Drawing.Point(25, 24);
            this.testAccountBtn.Name = "testAccountBtn";
            this.testAccountBtn.Size = new System.Drawing.Size(177, 29);
            this.testAccountBtn.TabIndex = 0;
            this.testAccountBtn.Text = "Test Account";
            this.testAccountBtn.UseVisualStyleBackColor = true;
            this.testAccountBtn.Click += new System.EventHandler(this.testAccountBtn_Click);
            // 
            // testCustomerBtn
            // 
            this.testCustomerBtn.Location = new System.Drawing.Point(36, 70);
            this.testCustomerBtn.Name = "testCustomerBtn";
            this.testCustomerBtn.Size = new System.Drawing.Size(138, 29);
            this.testCustomerBtn.TabIndex = 1;
            this.testCustomerBtn.Text = "Test Customer";
            this.testCustomerBtn.UseVisualStyleBackColor = true;
            this.testCustomerBtn.Click += new System.EventHandler(this.testCustomerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testCustomerBtn);
            this.Controls.Add(this.testAccountBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button testAccountBtn;
        private Button testCustomerBtn;
    }
}