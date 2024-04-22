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
    public partial class CustomerHomeForm : Form
    {
        public CustomerHomeForm()
        {
            InitializeComponent();
        }
        Customer customer;
        public CustomerHomeForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
            idLbl.Text = idLbl.Text + " " + customer.getId().ToString();
            passwordLbl.Text = passwordLbl.Text + " " + customer.getPassword().ToString();
            firstNameLbl.Text = firstNameLbl.Text + " " + customer.getFirstName().ToString();
            lastNameLbl.Text = lastNameLbl.Text + " " + customer.getLastName().ToString();
            addressLbl.Text = addressLbl.Text + " " + customer.getAddress().ToString();
            emailLbl.Text = emailLbl.Text + " " + customer.getEmail().ToString();
            //FirstNameTxtBox.Text = s1.getFirstName().ToString();
            //LastNameTxtBox.Text = s1.getLastName().ToString();
        }

        private void viewAccountsBtn_Click(object sender, EventArgs e)
        {
            customer.generateAccountsList();
            ViewAccountsForm viewAccountsForm = new ViewAccountsForm(customer);
            viewAccountsForm.Show();
        }
    }
}
