using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChattBank
{
    public partial class CreateCustomerForm : Form
    {
        public CreateCustomerForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Get the text from the TextBox
            string passwordText = passwordTxtBox.Text;
            string firstNameText = firstNameTxtBox.Text;
            string lastNameText = lastNameTxtBox.Text;
            string addressText = addressTxtBox.Text;
            string emailText = emailTxtBox.Text;

            // Check if the text is exactly 4 digits
            if (passwordText.Length != 4 || !int.TryParse(passwordText, out _))
            {
                // InValid input
                MessageBox.Show("Password must be 4 digits.");
                return;
            }
            if (string.IsNullOrEmpty(firstNameText) || string.IsNullOrEmpty(lastNameText) || string.IsNullOrEmpty(addressText) || string.IsNullOrEmpty(emailText))
            {
                MessageBox.Show("All of the fields must be filled out.");
                return;
            }
            Customer newCustomer = new Customer();
            int nextAvailableId = newCustomer.GetNextAvailableCustomerId();
            newCustomer = new Customer(nextAvailableId, Int32.Parse(passwordText), firstNameText, lastNameText, addressText, emailText);
            newCustomer.InsertDB();

        }
    }
}
