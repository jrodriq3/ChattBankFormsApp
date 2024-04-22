namespace ChattBank
{
    partial class ViewAccountsForm
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
            this.accountsDataGridView2 = new System.Windows.Forms.DataGridView();
            this.AcctNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.depOrWithdrawBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsDataGridView2
            // 
            this.accountsDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AcctNo,
            this.cid,
            this.type,
            this.balance});
            this.accountsDataGridView2.Location = new System.Drawing.Point(12, 103);
            this.accountsDataGridView2.Name = "accountsDataGridView2";
            this.accountsDataGridView2.RowHeadersWidth = 51;
            this.accountsDataGridView2.RowTemplate.Height = 29;
            this.accountsDataGridView2.Size = new System.Drawing.Size(776, 188);
            this.accountsDataGridView2.TabIndex = 0;
            this.accountsDataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AcctNo
            // 
            this.AcctNo.HeaderText = "Account Number";
            this.AcctNo.MinimumWidth = 6;
            this.AcctNo.Name = "AcctNo";
            this.AcctNo.Width = 125;
            // 
            // cid
            // 
            this.cid.HeaderText = "CID";
            this.cid.MinimumWidth = 6;
            this.cid.Name = "cid";
            this.cid.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 125;
            // 
            // balance
            // 
            this.balance.HeaderText = "Balance";
            this.balance.MinimumWidth = 6;
            this.balance.Name = "balance";
            this.balance.Width = 125;
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Location = new System.Drawing.Point(109, 367);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(163, 29);
            this.addAccountBtn.TabIndex = 1;
            this.addAccountBtn.Text = "Add Account";
            this.addAccountBtn.UseVisualStyleBackColor = true;
            this.addAccountBtn.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // depOrWithdrawBtn
            // 
            this.depOrWithdrawBtn.Location = new System.Drawing.Point(471, 367);
            this.depOrWithdrawBtn.Name = "depOrWithdrawBtn";
            this.depOrWithdrawBtn.Size = new System.Drawing.Size(190, 29);
            this.depOrWithdrawBtn.TabIndex = 2;
            this.depOrWithdrawBtn.Text = "Deposit or Withdraw";
            this.depOrWithdrawBtn.UseVisualStyleBackColor = true;
            this.depOrWithdrawBtn.Click += new System.EventHandler(this.depOrWithdrawBtn_Click);
            // 
            // ViewAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depOrWithdrawBtn);
            this.Controls.Add(this.addAccountBtn);
            this.Controls.Add(this.accountsDataGridView2);
            this.Name = "ViewAccountsForm";
            this.Text = "ViewAccountsForm";
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView accountsDataGridView2;
        private DataGridView accountsDataGridView;
        private DataGridViewTextBoxColumn AcctNo;
        private DataGridViewTextBoxColumn cid;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn balance;
        private Button addAccountBtn;
        private Button depOrWithdrawBtn;
    }
}