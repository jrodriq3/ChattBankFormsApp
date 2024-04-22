using System.Diagnostics;

namespace ChattBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testAccountBtn_Click(object sender, EventArgs e)
        {
            Account ac1= new Account();

            ac1.SelectDB(90011);


        }

        private void testCustomerBtn_Click(object sender, EventArgs e)
        {
            Customer cus1= new Customer(3007, 9797, "Jason", "Rodriguez", "Georgia", "JWR@gmail.com");
            cus1.deleteDB();
        }
    }
}