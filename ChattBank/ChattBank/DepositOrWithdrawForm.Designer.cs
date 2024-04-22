namespace ChattBank
{
    partial class DepositOrWithdrawForm
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
            this.amountLbl = new System.Windows.Forms.Label();
            this.amountLBox = new System.Windows.Forms.ListBox();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.accountNumberLbl = new System.Windows.Forms.Label();
            this.accountNumberLBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(487, 40);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(65, 20);
            this.amountLbl.TabIndex = 0;
            this.amountLbl.Text = "Amount:";
            // 
            // amountLBox
            // 
            this.amountLBox.FormattingEnabled = true;
            this.amountLBox.ItemHeight = 20;
            this.amountLBox.Items.AddRange(new object[] {
            "20",
            "100",
            "500",
            "1000",
            "5000"});
            this.amountLBox.Location = new System.Drawing.Point(638, 40);
            this.amountLBox.Name = "amountLBox";
            this.amountLBox.Size = new System.Drawing.Size(150, 104);
            this.amountLBox.TabIndex = 1;
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(151, 372);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(94, 29);
            this.depositBtn.TabIndex = 2;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(525, 372);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(94, 29);
            this.withdrawBtn.TabIndex = 3;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // accountNumberLbl
            // 
            this.accountNumberLbl.AutoSize = true;
            this.accountNumberLbl.Location = new System.Drawing.Point(21, 27);
            this.accountNumberLbl.Name = "accountNumberLbl";
            this.accountNumberLbl.Size = new System.Drawing.Size(124, 20);
            this.accountNumberLbl.TabIndex = 4;
            this.accountNumberLbl.Text = "Account Number:";
            // 
            // accountNumberLBox
            // 
            this.accountNumberLBox.FormattingEnabled = true;
            this.accountNumberLBox.ItemHeight = 20;
            this.accountNumberLBox.Location = new System.Drawing.Point(173, 27);
            this.accountNumberLBox.Name = "accountNumberLBox";
            this.accountNumberLBox.Size = new System.Drawing.Size(150, 204);
            this.accountNumberLBox.TabIndex = 5;
            // 
            // DepositOrWithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accountNumberLBox);
            this.Controls.Add(this.accountNumberLbl);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.amountLBox);
            this.Controls.Add(this.amountLbl);
            this.Name = "DepositOrWithdrawForm";
            this.Text = "DepositOrWithdrawForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label amountLbl;
        private ListBox amountLBox;
        private Button depositBtn;
        private Button withdrawBtn;
        private Label accountNumberLbl;
        private ListBox accountNumberLBox;
    }
}