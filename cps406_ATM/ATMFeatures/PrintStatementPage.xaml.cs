using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for PrintStatementPage.xaml
    /// </summary>
    public partial class PrintStatementPage : Page
    {
        CardAccount userAccount;
        BankAccount savingsAccount;
        BankAccount checkingsAccount;
        MainWindow home;
        public PrintStatementPage(CardAccount account, MainWindow context)
        {
            InitializeComponent();
            userAccount = account;
            home = context;
            GetAccounts();
        }

        public void GetAccounts()
        {
            savingsAccount = userAccount.GetCheckingsAccount();
            checkingsAccount = userAccount.GetSavingsAccount();
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            home.Content = new BankHomePage(userAccount, home);
        }

        private void button_option8_Click(object sender, RoutedEventArgs e)
        {
            home.Content = new BankHomePage(userAccount, home);
        }

        private void button_option1_Click(object sender, RoutedEventArgs e)
        {
            double totalBalance = savingsAccount.balance + checkingsAccount.balance;
            // Print all accounts
            using (StreamWriter writer = new StreamWriter("allstatment.txt"))
            {
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("          CPS406_ATM Project");
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("Date: " + DateTime.Today.ToString("d"));
                writer.WriteLine("Time: " + DateTime.Now.ToString("h:mm:ss tt"));
                writer.WriteLine("Card Number: **** **** **** " + userAccount.GetCardNumber().Substring(userAccount.GetCardNumber().Length - 4));
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("Savings Account");
                writer.WriteLine("Balance: " + savingsAccount.balance);
                writer.WriteLine("Limit: " + savingsAccount.limit);
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("Checkings Account");
                writer.WriteLine("Balance: " + checkingsAccount.balance);
                writer.WriteLine("Limit: " + checkingsAccount.limit);
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("Total Balance: " + totalBalance);
                writer.WriteLine("-----------------------------------------");
            }
            labelStatus.Content = "You have printed your account statement.";
        }

        private void button_option2_Click(object sender, RoutedEventArgs e)
        {
            // Print savings account
            using (StreamWriter writer = new StreamWriter("savingsstatement.txt"))
            {
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("          CPS406_ATM Project");
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("Date: " + DateTime.Today.ToString("d"));
                writer.WriteLine("Time: " + DateTime.Now.ToString("h:mm:ss tt"));
                writer.WriteLine("Card Number: **** **** **** " + userAccount.GetCardNumber().Substring(userAccount.GetCardNumber().Length - 4));
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("Savings Account");
                writer.WriteLine("Balance: " + savingsAccount.balance);
                writer.WriteLine("Limit: " + savingsAccount.limit);
                writer.WriteLine("-----------------------------------------");
            }
            labelStatus.Content = "You have printed your account statement.";
        }

        private void button_option3_Click(object sender, RoutedEventArgs e)
        {
            // Print checkings
            using (StreamWriter writer = new StreamWriter("checkingsstatment.txt"))
            {
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("          CPS406_ATM Project");
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("Date: " + DateTime.Today.ToString("d"));
                writer.WriteLine("Time: " + DateTime.Now.ToString("h:mm:ss tt"));
                writer.WriteLine("Card Number: **** **** **** " + userAccount.GetCardNumber().Substring(userAccount.GetCardNumber().Length - 4));
                writer.WriteLine("-----------------------------------------");
                writer.WriteLine("Checkings Account");
                writer.WriteLine("Balance: " + checkingsAccount.balance);
                writer.WriteLine("Limit: " + checkingsAccount.limit);
                writer.WriteLine("-----------------------------------------");
            }
            labelStatus.Content = "You have printed your account statement.";
        }
    }
}
