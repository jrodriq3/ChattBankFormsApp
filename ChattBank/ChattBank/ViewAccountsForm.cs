using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattBank
{
    public partial class ViewAccountsForm : Form
    {
        Customer customer;
        public ViewAccountsForm(Customer customer)
        {


            InitializeComponent();
            

            
            
            this.customer = customer;
            accountsDataGridView2.Rows.Clear();
            foreach (var account in customer.accounts) {
                accountsDataGridView2.Rows.Add(account.getAccountNumber().ToString(), account.getCid().ToString(), account.getType().ToString(), account.getBalance().ToString());
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccountForm = new AddAccountForm(customer);
            addAccountForm.Show();
        }

        private void depOrWithdrawBtn_Click(object sender, EventArgs e)
        {
            DepositOrWithdrawForm depositOrWithdrawForm = new DepositOrWithdrawForm(customer);
            depositOrWithdrawForm.Show();
        }
    }
}
