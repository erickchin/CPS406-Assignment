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
    /// Interaction logic for BalanceInquiryPage.xaml
    /// </summary>
    public partial class BalanceInquiryPage : Page
    {
        CardAccount userAccount;
        BankAccount savingsAccount;
        BankAccount checkingsAccount;
        MainWindow home;
        public BalanceInquiryPage(CardAccount account, MainWindow context)
        {
            InitializeComponent();
            userAccount = account;
            home = context;
            GetAccount();
            RecieveInfoFromBank();
        }

        public void GetAccount()
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

        public double GetSavingsBalance()
        {
            return savingsAccount.balance;
        }

        public double GetCheckingsBalance()
        {
            return checkingsAccount.balance;
        }

        public void RecieveInfoFromBank()
        {
            labelCheckingsBalance.Content = GetSavingsBalance();
            labelSavingsBalance.Content = GetCheckingsBalance();
        }
    }
}
