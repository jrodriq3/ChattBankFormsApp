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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (idTxtBox.Text == "admin" && passwordTxtBox.Text == "123")
            {
                AdminHomeForm adminHomeForm= new AdminHomeForm();
                adminHomeForm.Show();
            }
            else
            {
                MessageBox.Show("Id or password were incorrect.");
            }
        }
    }
}
