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
    /// Interaction logic for WithdrawPage.xaml
    /// </summary>
    public partial class WithdrawPage : Page
    {
        CardAccount userAccount;
        BankAccount bankAccount;
        MainWindow home;
        bool enableInput = false;
        string customAmount;
        public WithdrawPage(CardAccount account, string type, MainWindow context)
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
            if (enableInput)
            {
                labelStatus.Content = "";
                enableInput = false;
            }
            else
            {
                home.Content = new WithdrawHomePage(userAccount, home);
            }
        }

        private void button_option1_Click(object sender, RoutedEventArgs e)
        {
            // 200
            bool status = bankAccount.WithdrawMoney(200);
            if (status == true)
            {
                labelStatus.Content = "You have withdrawn $200.";
            }
            else
            {
                labelStatus.Content = "Your withdrawal is over your limit or balance.";
            }
            UpdateBalance();
        }

        private void button_option2_Click(object sender, RoutedEventArgs e)
        {
            // 100
            bool status = bankAccount.WithdrawMoney(100);
            if (status == true)
            {
                labelStatus.Content = "You have withdrawn $100.";
            }
            else
            {
                labelStatus.Content = "Your withdrawal is over your limit or balance.";
            }
            UpdateBalance();
        }

        private void button_option3_Click(object sender, RoutedEventArgs e)
        {
            // 50
            bool status = bankAccount.WithdrawMoney(50);
            if (status == true)
            {
                labelStatus.Content = "You have withdrawn $50.";
            }
            else
            {
                labelStatus.Content = "Your withdrawal is over your limit or balance.";
            }
            UpdateBalance();
        }

        private void button_option4_Click(object sender, RoutedEventArgs e)
        {
            // 20
            bool status = bankAccount.WithdrawMoney(20);
            if (status == true)
            {
                labelStatus.Content = "You have withdrawn $20.";
            }
            else
            {
                labelStatus.Content = "Your withdrawal is over your limit or balance.";
            }
            UpdateBalance();
        }

        private void button_option5_Click(object sender, RoutedEventArgs e)
        {
            // 10
            bool status = bankAccount.WithdrawMoney(10);
            if (status == true)
            {
                labelStatus.Content = "You have withdrawn $10.";
            }
            else
            {
                labelStatus.Content = "Your withdrawal is over your limit or balance.";
            }
            UpdateBalance();
        }

        private void button_option6_Click(object sender, RoutedEventArgs e)
        {
            // 5
            bool status = bankAccount.WithdrawMoney(5);
            if (status == true)
            {
                labelStatus.Content = "You have withdrawn $5.";
            }
            else
            {
                labelStatus.Content = "Your withdrawal is over your limit or balance.";
            }
            UpdateBalance();
        }

        private void button_option8_Click(object sender, RoutedEventArgs e)
        {
            home.Content = new WithdrawHomePage(userAccount, home);
        }

        private void button_option7_Click(object sender, RoutedEventArgs e)
        {
            enableInput = true;
            labelStatus.Content = "Enter the amount to withdraw:";
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 1;
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 2;
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 3;
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 4;
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 5;
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 6;
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 7;
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 8;
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 9;
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount += 0;
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                customAmount = "";
                labelStatus.Content = "Enter the amount to withdraw: " + customAmount;
            }
        }

        private void button_enter_Click(object sender, RoutedEventArgs e)
        {
            if (enableInput)
            {
                bool status = bankAccount.WithdrawMoney(Double.Parse(customAmount));
                if (status == true)
                {
                    labelStatus.Content = "You have withdrawn: " + customAmount;
                    customAmount = "";
                    enableInput = false;
                }
                else
                {
                    labelStatus.Content = "Your withdrawal is over your limit or balance. Select another option.";
                    customAmount = "";
                    enableInput = false;
                }
                UpdateBalance();
            }
        }
    }
}
