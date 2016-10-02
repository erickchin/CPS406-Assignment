using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace cps406_ATM
{
    public class Database
    {
        SQLiteConnection sqlConnection;
        public Database()
        {
            sqlConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            sqlConnection.Open();
        }

        public DataTable GetTransactions(string cardNumber)
        {
            string sql = "SELECT date,type,amount FROM transactions WHERE card="+cardNumber;
            SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
            command.ExecuteNonQuery();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
     
            return dataTable;
        }

        public bool VerifyPin(string cardNumber, string pin)
        {
            string sql = "SELECT * FROM accounts WHERE card=" + cardNumber + " AND pin=" + pin;
            SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateCard(string cardNumber)
        {
            string sql = "SELECT * FROM accounts WHERE card=" + cardNumber;
            SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetBalance(string cardNumber, string type)
        {
            if (type == "Checkings")
            {
                string sql = "SELECT cbalance FROM accounts WHERE card=" + cardNumber;
                SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
                return (Double)command.ExecuteScalar();
            }
            else if (type == "Savings")
            {
                string sql = "SELECT sbalance FROM accounts WHERE card=" + cardNumber;
                SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
                return (Double)command.ExecuteScalar();
            }
            else
            {
                return -1;
            }
        }

        public double GetLimit(string cardNumber, string type)
        {
            if (type == "Checkings")
            {
                string sql = "SELECT climit FROM accounts WHERE card=" + cardNumber;
                SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
                return (Double)command.ExecuteScalar();
            }
            else if (type == "Savings")
            {
                string sql = "SELECT slimit FROM accounts WHERE card=" + cardNumber;
                SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
                return (Double)command.ExecuteScalar();
            }
            else
            {
                return -1;
            }
        }

        public void ChangeBalance(string cardNumber, string type, double balance)
        {
            if (type == "Checkings")
            {
                string sql = "UPDATE accounts SET cbalance=" + balance + " WHERE card='" + cardNumber + "'";
                SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
                command.ExecuteScalar();
            }
            else if (type == "Savings")
            {
                string sql = "UPDATE accounts SET sbalance=" + balance + " WHERE card='" + cardNumber + "'";
                SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
                command.ExecuteScalar();
            }
        }

        public void AddTransaction(string cardNumber, string type, double amount)
        {
            string sql = "INSERT INTO transactions (card, type, amount) VALUES ('" + cardNumber + "','" + type + "','" + amount + "')";
            SQLiteCommand command = new SQLiteCommand(sql, sqlConnection);
            command.ExecuteScalar();
        }
    }
}
