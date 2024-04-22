namespace ChattBank
{
    partial class DeleteCustomerForm
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
            this.customerIdLbl = new System.Windows.Forms.Label();
            this.customerIdLBox = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerIdLbl
            // 
            this.customerIdLbl.AutoSize = true;
            this.customerIdLbl.Location = new System.Drawing.Point(260, 9);
            this.customerIdLbl.Name = "customerIdLbl";
            this.customerIdLbl.Size = new System.Drawing.Size(94, 20);
            this.customerIdLbl.TabIndex = 0;
            this.customerIdLbl.Text = "Customer ID:";
            // 
            // customerIdLBox
            // 
            this.customerIdLBox.FormattingEnabled = true;
            this.customerIdLBox.ItemHeight = 20;
            this.customerIdLBox.Location = new System.Drawing.Point(360, 12);
            this.customerIdLBox.Name = "customerIdLBox";
            this.customerIdLBox.Size = new System.Drawing.Size(150, 364);
            this.customerIdLBox.TabIndex = 1;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(363, 404);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DeleteCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.customerIdLBox);
            this.Controls.Add(this.customerIdLbl);
            this.Name = "DeleteCustomerForm";
            this.Text = "DeleteCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label customerIdLbl;
        private ListBox customerIdLBox;
        private Button deleteBtn;
    }
}