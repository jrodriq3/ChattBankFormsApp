using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattBank
{
    public partial class DepositOrWithdrawForm : Form
    {
        Customer customer;
        List<int> customerAccountNumbers;
        public DepositOrWithdrawForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            accountNumberLBox.Items.Clear();
            populateCustomerAccountNumbers();
            foreach (int number in customerAccountNumbers)
            {
                accountNumberLBox.Items.Add(number);
            }
        }
        public void populateCustomerAccountNumbers()
        {
            customerAccountNumbers = new List<int>();
            foreach (Account act in customer.accounts)
            {
                customerAccountNumbers.Add(act.getAccountNumber());
            }
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (accountNumberLBox.SelectedItem != null && amountLBox.SelectedItem != null)
            {
                int selectedAccountNumber = Int32.Parse(accountNumberLBox.Text);
                int selectedAmount = Int32.Parse(amountLBox.Text);
                Account selectedAccount = new Account();
                selectedAccount.SelectDB(selectedAccountNumber);
                double currentBalance = Double.Parse(selectedAccount.getBalance());
                double newBalance = currentBalance + selectedAmount;
                selectedAccount.setBalance(newBalance.ToString());
                selectedAccount.updateDB();
                MessageBox.Show("Deposit Complete Close all windows and reopen program to see updated balance.");
            }
            else
            {
                MessageBox.Show("You must select an account and an amount.");
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (accountNumberLBox.SelectedItem != null && amountLBox.SelectedItem != null)
            {
                int selectedAccountNumber = Int32.Parse(accountNumberLBox.Text);
                int selectedAmount = Int32.Parse(amountLBox.Text);
                Account selectedAccount = new Account();
                selectedAccount.SelectDB(selectedAccountNumber);
                double currentBalance = Double.Parse(selectedAccount.getBalance());
                if (currentBalance - selectedAmount < 0)
                {
                    MessageBox.Show("You do not have enough in your account to cover this withdrawal.");
                    return;
                }
                double newBalance = currentBalance - selectedAmount;
                selectedAccount.setBalance(newBalance.ToString());
                selectedAccount.updateDB();
                MessageBox.Show("Withdrawal Complete Close all windows and reopen program to see updated balance.");
            }
            else
            {
                MessageBox.Show("You must select an account and an amount.");
            }
        }
    }
}
