using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cps406_ATM
{
    public class CardAccount
    {
        private BankAccount savingsAccount;
        private BankAccount checkingsAccount;
        string cardNumber;
        Database data = new Database();

        public bool VerifyPin(string card_number, string pin)
        {
            cardNumber = card_number;
            if (data.VerifyPin(card_number, pin))
            {
                savingsAccount = new BankAccount(card_number, "Savings");
                checkingsAccount = new BankAccount(card_number, "Checkings");
                return true;
            }
            else
            {
                return false;
            }
        }

        public BankAccount GetSavingsAccount()
        {
            return savingsAccount;
        }

        public BankAccount GetCheckingsAccount()
        {
            return checkingsAccount;
        }

        public string GetCardNumber()
        {
            return cardNumber;
        }
    }
}
