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
    public partial class DeleteCustomerForm : Form
    {
        List<int> customerIdNumbers;

        public DeleteCustomerForm()
        {
            InitializeComponent();
            Customer customer= new Customer();
            customerIdNumbers = customer.getAllCustomerIds();
            customerIdLBox.Items.Clear();
            foreach (int id in customerIdNumbers)
            {
                customerIdLBox.Items.Add(id);
            }
            MessageBox.Show("Deleting a customer will delete all accounts associated with that customer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            if (customerIdLBox.SelectedItem == null)
            {
                MessageBox.Show("You must select a customer Id to delete.");
                return;
            }
            int customerId = Int32.Parse(customerIdLBox.Text);
            Customer customerToDelete = new Customer();
            customerToDelete.SelectDB(customerId);
            customerToDelete.deleteAllCustomerAccounts();
            customerToDelete.deleteDB();
            MessageBox.Show("Customer Deleted.");
            
        }
    }
}
