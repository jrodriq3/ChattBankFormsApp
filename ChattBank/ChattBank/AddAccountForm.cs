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
    public partial class AddAccountForm : Form
    {
        Customer customer;
        int nextAvailableAccountNumber;

        public AddAccountForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Account act = new Account();

            nextAvailableAccountNumber = act.GetNextAvailableAccountNumber();
            if (typeLBox.SelectedItem != null)
            {
                string selectedAccountType = typeLBox.SelectedItem.ToString();
                Account newAccount = new Account(nextAvailableAccountNumber, customer.getId(), selectedAccountType, "0.0");
                newAccount.InsertDB();
                MessageBox.Show("New account created.");

            }
            else
            {
                MessageBox.Show("You must select an account type");
            }
        }
    }
}
