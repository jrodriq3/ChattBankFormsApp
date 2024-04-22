using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*
Jason Rodriguez 
CIST 2342
4/15/2024
*/


namespace ChattBank
{
    public class Customer
    {
        private int id;
        private int password;
        private string firstName;
        private string lastName;
        private string address;
        private string email;
        private OleDbDataAdapter dataAdapter;
        private OleDbConnection connection;
        private OleDbDataReader dr;
        private OleDbCommand OleDbSelectCommand;
        private OleDbCommand OleDbInsertCommand;
        private OleDbCommand OleDbUpdateCommand;
        private OleDbCommand OleDbDeleteCommand;
        private string cmd;
        // List to hold customer's accounts
        public List<Account> accounts = new List<Account>();


        // Constructor with parameters
        public Customer(int id, int password, string firstName, string lastName, string address, string email)
        {
            this.id = id;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.email = email;
        }
        // Default constructor
        public Customer() 
        {
            id = 0;
            password = 0;
            firstName = "";
            lastName = "";
            address = "";
            email = "";
        }
        // Method to set up database connection
        public void DBSetup()
        {
            // Initialize data adapter, connection, and command objects
            dataAdapter = new OleDbDataAdapter();
            OleDbSelectCommand = new OleDbCommand();
            OleDbInsertCommand = new OleDbCommand();
            OleDbUpdateCommand = new OleDbCommand();
            OleDbDeleteCommand = new OleDbCommand();
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\jason\\OneDrive\\Desktop\\ChattBankMDB.mdb");
            // Set data adapter commands
            dataAdapter.DeleteCommand = OleDbDeleteCommand;
            dataAdapter.InsertCommand = OleDbInsertCommand;
            dataAdapter.SelectCommand = OleDbSelectCommand;
            dataAdapter.UpdateCommand = OleDbUpdateCommand;

        }  //end DBSetup()

        // Method to generate a list of accounts associated with the customer
        public void generateAccountsList()
        {
            // Set up database connection
            DBSetup();
            // SQL query to select accounts for the customer
            cmd = "Select * from Accounts where Cid = '" + id + "'";
            dataAdapter.SelectCommand.CommandText = cmd;
            dataAdapter.SelectCommand.Connection = connection;
            try
            {
                connection.Open();
                dr = dataAdapter.SelectCommand.ExecuteReader();
                // Check if result set has rows
                if (dr.HasRows)
                {
                    
                    // Loop through each row in the result set
                    while (dr.Read())
                    {
                        
                        // Create a new Account object and set its properties
                        Account account = new Account();
                        
                        account.setAccountNumber(Int32.Parse(dr.GetValue(0) + ""));
                        
                        account.setCid(Int32.Parse(dr.GetValue(1) + ""));
                        
                        account.setType(dr.GetValue(2) + "");
                        
                        account.setBalance(dr.GetValue(3) + "");
                        
                        // Add the account to the list of accounts associated with the customer
                        // Assuming you have a list of accounts in your Customer class
                        accounts.Add(account);
                        
                    }
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        // Method to get all customer IDs from the database
        public List<int> getAllCustomerIds()
        {
            DBSetup();
            cmd = "Select CustID from Customers";
            dataAdapter.SelectCommand.CommandText = cmd;
            dataAdapter.SelectCommand.Connection = connection;
            // List to store customer IDs
            List<int> allCustomerIds = new List<int>();
            try
            {
                connection.Open();
                dr= dataAdapter.SelectCommand.ExecuteReader();
                // Loop through result set and add customer IDs to list
                while (dr.Read())
                {
                    int customerId = Convert.ToInt32(dr["CustID"]);
                    allCustomerIds.Add(customerId);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return new List<int>();
                
            }
            finally
            {
                connection.Close();
                
            }
            return allCustomerIds;


        }
        // Method to retrieve customer data from the database
        public void SelectDB(int id)
        { //++++++++++++++++++++++++++  SELECT +++++++++++++++++++++++++
            DBSetup();
            cmd = "Select * from Customers where CustID = '" + id + "'";
            dataAdapter.SelectCommand.CommandText = cmd;
            dataAdapter.SelectCommand.Connection = connection;
            Debug.WriteLine(cmd);
            try
            {
                connection.Open();
                dr = dataAdapter.SelectCommand.ExecuteReader();


                // Read the data and set properties
                dr.Read();
                this.id = id;
                setPassword(Int32.Parse(dr.GetValue(1) + ""));
                setFirstName(dr.GetValue(2) + "");
                setLastName(dr.GetValue(3) + "");
                setAddress(dr.GetValue(4) + "");
                setEmail(dr.GetValue(5) + "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        } //end SelectDB()

        // Method to insert customer data into the database
        public void InsertDB()
        {
            DBSetup();
            cmd = "INSERT into Customers values('" + getId() + "'," +
                                    "'" + getPassword() + "'," +
                                "'" + getFirstName() + "'," +
                                "'" + getLastName() + "'," +
                                "'" + getAddress() + "'," +
                                "'" + getEmail() + "')";
            dataAdapter.InsertCommand.CommandText = cmd;
            dataAdapter.InsertCommand.Connection = connection;
            Debug.WriteLine(cmd);
            try
            {
                connection.Open();
                int n = dataAdapter.InsertCommand.ExecuteNonQuery();
                if (n == 1)
                    Debug.WriteLine("Data Inserted");
                else
                    Debug.WriteLine("ERROR: Inserting Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        } //end insertDB()

        // Method to update customer database
        public void updateDB()
        {
            //++++++++++++++++++++++++++  UPDATE  +++++++++++++++++++++++++
            DBSetup();
            cmd = "Update Customers set CustPassword = '" + getPassword() + "'," +
                         "CustFirstName = '" + getFirstName() + "'," +
                         "CustLastName = '" + getLastName() + "'," +
                         "CustAddress = '" + getAddress() + "'," +
                         "CustEmail = '" + getEmail() + 
                         "' where CustID = '" + getId() + "'";

            dataAdapter.UpdateCommand.CommandText = cmd;
            dataAdapter.UpdateCommand.Connection = connection;
            Debug.WriteLine(cmd);
            try
            {
                connection.Open();
                int n = dataAdapter.UpdateCommand.ExecuteNonQuery();
                if (n == 1)
                    Debug.WriteLine("Data Updated");
                else
                    Debug.WriteLine("ERROR: Updating Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        } //end UpdateDB()

        // Method to delete a customer from the database
        public void deleteDB()
        {
            //++++++++++++++++++++++++++  DELETE  +++++++++++++++++++++++++
            DBSetup();
            cmd = "Delete from Customers where CustID = '" + getId() + "'";
            dataAdapter.DeleteCommand.CommandText = cmd;
            dataAdapter.DeleteCommand.Connection = connection;
            Debug.WriteLine(cmd);
            try
            {
                connection.Open();
                int n = dataAdapter.DeleteCommand.ExecuteNonQuery();
                if (n == 1)
                    Debug.WriteLine("Data Deleted");
                else
                    Debug.WriteLine("ERROR: Deleting Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        } //end DelectDB()

        // Method to generate the next available id from database
        public int GetNextAvailableCustomerId()
        {
            int nextCustomerId = 0;

            // Setup database connection
            DBSetup();

            // Query to find the highest existing account number
            cmd = "SELECT MAX(CustID) FROM Customers";

            dataAdapter.SelectCommand.CommandText = cmd;
            dataAdapter.SelectCommand.Connection = connection;

            try
            {
                connection.Open();
                object result = dataAdapter.SelectCommand.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    nextCustomerId = Convert.ToInt32(result) + 1;
                }
                else
                {
                    // If no account exists yet, start account numbers from 1
                    nextCustomerId = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return nextCustomerId;
        }
        // Method to delete all accounts associated with a customer
        public void deleteAllCustomerAccounts()
        {
            foreach (Account act in accounts)
            {
                act.deleteDB();
            }
        }

        // Method to display customer properties for testing purposes
        public void display()
        {
            Debug.WriteLine("");
            Debug.WriteLine("Customer ID: " + id);
            Debug.WriteLine("Customer Password: " + password);
            Debug.WriteLine("Customer First Name: " + firstName);
            Debug.WriteLine("Customer Last Name: " + lastName);
            Debug.WriteLine("Customer Address: " + address);
            Debug.WriteLine("Customer Email: " + email);
        }
        public int getId() { return id; }
        public int getPassword() { return password; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getAddress() { return address; }
        public string getEmail() { return email; }
        public void setId(int id) { this.id = id; }
        public void setPassword(int password) { this.password = password; }
        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setAddress(string address) { this.address = address; }
        public void setEmail(string email) { this.email = email; }


    }
}
