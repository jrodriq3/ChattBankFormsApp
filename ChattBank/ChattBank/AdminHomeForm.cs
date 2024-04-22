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
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void createCustomerBtn_Click(object sender, EventArgs e)
        {
            CreateCustomerForm createCustomerForm= new CreateCustomerForm();
            createCustomerForm.Show();
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            DeleteCustomerForm deleteCustomerForm= new DeleteCustomerForm();
            deleteCustomerForm.Show();
        }
    }
}
