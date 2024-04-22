using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattBank
{
    public class Account
    {
        private int accountNumber;
        private int cid;
        private string type;
        private string balance;
        private OleDbDataAdapter dataAdapter;
        private OleDbConnection connection;
        private OleDbDataReader dr;
        private OleDbCommand OleDbSelectCommand;
        private OleDbCommand OleDbInsertCommand;
        private OleDbCommand OleDbUpdateCommand;
        private OleDbCommand OleDbDeleteCommand;
        private string cmd;
        public Account(int accountNumber, int cid, string type, string balance)
        {
            this.accountNumber = accountNumber;
            this.cid = cid;
            this.type = type;
            this.balance = balance;
        }
        public Account()
        {
            accountNumber= 0;
            cid = 0;
            type = "";
            balance = "";
        }
        public void DBSetup()
        {
            dataAdapter = new OleDbDataAdapter();
            OleDbSelectCommand = new OleDbCommand();
            OleDbInsertCommand = new OleDbCommand();
            OleDbUpdateCommand = new OleDbCommand();
            OleDbDeleteCommand = new OleDbCommand();
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\jason\\OneDrive\\Desktop\\ChattBankMDB.mdb");
            dataAdapter.DeleteCommand = OleDbDeleteCommand;
            dataAdapter.InsertCommand = OleDbInsertCommand;
            dataAdapter.SelectCommand = OleDbSelectCommand;
            dataAdapter.UpdateCommand = OleDbUpdateCommand;

        }  //end DBSetup()
        public void InsertDB()
        {
            DBSetup();
            cmd = "INSERT into Accounts values('" + getAccountNumber() + "'," +
                                    "'" + getCid() + "'," +
                                "'" + getType() + "'," +
                                "'" + getBalance() + "')";
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
        public void SelectDB(int accountNumber)
        { //++++++++++++++++++++++++++  SELECT +++++++++++++++++++++++++
            DBSetup();
            cmd = "Select * from Accounts where AcctNo = '" + accountNumber + "'";
            dataAdapter.SelectCommand.CommandText = cmd;
            dataAdapter.SelectCommand.Connection = connection;
            Debug.WriteLine(cmd);
            try
            {
                connection.Open();
                dr = dataAdapter.SelectCommand.ExecuteReader();
                
                

                dr.Read();
                this.accountNumber = accountNumber;
                
                setCid(Int32.Parse(dr.GetValue(1) + ""));
                setType(dr.GetValue(2) + "");

                setBalance(dr.GetValue(3) + "");

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
        public void updateDB()
        {
            //++++++++++++++++++++++++++  UPDATE  +++++++++++++++++++++++++
            DBSetup();
            cmd = "Update Accounts set Cid = '" + getCid() + "'," +
                         "Type = '" + getType() + "'," +
                         "Balance = '" + getBalance() + 
                         "' where AcctNo = '" + getAccountNumber() + "'";

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
        public void deleteDB()
        {
            //++++++++++++++++++++++++++  DELETE  +++++++++++++++++++++++++
            DBSetup();
            cmd = "Delete from Accounts where AcctNo = '" + getAccountNumber() + "'";
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
        public int GetNextAvailableAccountNumber()
        {
            int nextAccountNumber = 0;

            // Setup database connection
            DBSetup();

            // Query to find the highest existing account number
            cmd = "SELECT MAX(AcctNo) FROM Accounts";

            dataAdapter.SelectCommand.CommandText = cmd;
            dataAdapter.SelectCommand.Connection = connection;

            try
            {
                connection.Open();
                object result = dataAdapter.SelectCommand.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    nextAccountNumber = Convert.ToInt32(result) + 1;
                }
                else
                {
                    // If no account exists yet, start account numbers from 1
                    nextAccountNumber = 1;
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

            return nextAccountNumber;
        }
        public void display()
        {
            Debug.WriteLine("");
            Debug.WriteLine("Account Number: " + accountNumber);
            Debug.WriteLine("CID: " + cid);
            Debug.WriteLine("Type: " + type);
            Debug.WriteLine("Balance: " + balance);
        }
        public int getAccountNumber()
        {
            return accountNumber;
        }
        public void setAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }
        public int getCid()
        {
            return cid;
        }
        public void setCid(int cid)
        {
            this.cid = cid;
        }
        public string getType()
        {
            return type;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public string getBalance()
        {
            return balance;
        }
        public void setBalance(string balance)
        {
            this.balance = balance;
        }
    }
}
//string strBalance = dr.GetValue(3) + "";
//strBalance = strBalance.Replace("$", "").Replace(",", "");
//double balance = double.Parse(strBalance, CultureInfo.InvariantCulture);
