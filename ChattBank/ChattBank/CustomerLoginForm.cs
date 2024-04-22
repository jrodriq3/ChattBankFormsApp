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
    public partial class CustomerLoginForm : Form
    {
        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private void CustomerLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int customerId = 0;
            int customerPassword = 0;
            try
            {
                customerId = Int32.Parse(idTxtBox.Text);
                customerPassword = Int32.Parse(passwordTxtBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error with the id or password provided both must be a number.");
                return;
            }


            Customer customer = new Customer();
            customer.SelectDB(customerId);
            if (customer.getId() == 0)
            {
                MessageBox.Show("The id provided is not a recognized one.");
                return;
            }
            if (customer.getPassword() != customerPassword)
            {
                MessageBox.Show("The provided password is not correct");
                return;
            }

            CustomerHomeForm customerHomeForm = new CustomerHomeForm(customer);
            customerHomeForm.Show();
        }
    }
}
