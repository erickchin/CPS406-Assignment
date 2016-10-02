using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cps406_ATM
{
    public class BankAccount
    {
        public String accountType { get; set; }
        public double balance { get; set; }
        public double limit { get; set; }
        public String cardNumber { get; set; } 
        Database data = new Database();

        public BankAccount(string card, String type)
        {
            accountType = type;
            cardNumber = card;
            GetInformation(cardNumber);
        }

        public void GetInformation(string cardNumber)
        {
            balance = data.GetBalance(cardNumber, accountType);
            limit = data.GetLimit(cardNumber, accountType);
        }

        public bool WithdrawMoney(double amount)
        {
            if (amount <= limit || amount > balance)
            {
                balance -= amount;
                data.ChangeBalance(cardNumber, accountType, balance);
                data.AddTransaction(cardNumber, accountType + ": Withdraw", amount);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DepositMoney(double amount)
        {
            balance += amount;
            data.ChangeBalance(cardNumber, accountType, balance);
            data.AddTransaction(cardNumber, accountType + ": Deposit", amount);
            return true;
        }
    }
}
