using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cps406_ATM
{
    /// <summary>
    /// Interaction logic for DepositPage.xaml
    /// </summary>
    public partial class DepositPage : Page
    {
        CardAccount userAccount;
        BankAccount bankAccount;
        MainWindow home;
        bool depositing = false;
        bool customDepositing = false;
        bool enableInput = false;
        int amount;
        string customAmount;
        public DepositPage(CardAccount account, string type, MainWindow context)
        {
            InitializeComponent();
            userAccount = account;
            home = context;
            GetAccount(type);
            UpdateBalance();
        }

        public void GetAccount(string bankType)
        {
            if (bankType == "Checkings")
            {
                bankAccount = userAccount.GetCheckingsAccount();
            }
            else if (bankType == "Savings")
            {
                bankAccount = userAccount.GetSavingsAccount();
            }
        }

        public void UpdateBalance()
        {
            labelBalance.Content = "Balance: " + bankAccount.balance;
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput || depositing)
            {
                labelStatus.Content = "";
                enableInput = false;
                customDepositing = false;
                depositing = false;
            }
            else
            {
                home.Content = new DepositHomePage(userAccount, home);
            }
        }

        private void button_option1_Click(object sender, RoutedEventArgs e)
        {
            labelStatus.Content = "Insert your $100 bill...";
            amount = 100;
            depositing = true;
        }

        private void button_option2_Click(object sender, RoutedEventArgs e)
        {
            labelStatus.Content = "Insert your $50 bill...";
            amount = 50;
            depositing = true;
        }

        private void button_option3_Click(object sender, RoutedEventArgs e)
        {
            labelStatus.Content = "Insert your $20 bill...";
            amount = 20;
            depositing = true;
        }

        private void button_option4_Click(object sender, RoutedEventArgs e)
        {
            labelStatus.Content = "Insert your $10 bill...";
            amount = 10;
            depositing = true;
        }

        private void button_option5_Click(object sender, RoutedEventArgs e)
        {
            labelStatus.Content = "Insert your $5 bill...";
            amount = 5;
            depositing = true;

        }

        private void button_insertBill_Click(object sender, RoutedEventArgs e)
        {
            if (depositing)
            {
                bankAccount.DepositMoney(amount);
                UpdateBalance();
                labelStatus.Content = "Success!";
                depositing = false;
                amount = 0;
            }
            else if (customDepositing)
            {
                bankAccount.DepositMoney(Double.Parse(customAmount));
                UpdateBalance();
                labelStatus.Content = "Success!";
                customDepositing = false;
                enableInput = false;
                amount = 0;
            }
        }

        private void button_option8_Click(object sender, RoutedEventArgs e)
        {
            home.Content = new WithdrawHomePage(userAccount, home);
        }

        private void button_option6_Click(object sender, RoutedEventArgs e)
        {
            enableInput = true;
            labelStatus.Content = "Enter the amount to deposit:";
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 1;
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 2;
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 3;
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 4;
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 5;
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 6;
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 7;
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 8;
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 9;
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 0;
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount = "";
                labelStatus.Content = "Enter the amount to deposit: " + customAmount;
            }
        }

        private void button_enter_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customDepositing = true;
                depositing = false;
                labelStatus.Content = "Enter your bill(s) into the machine.";
            }
        }
    }
}
