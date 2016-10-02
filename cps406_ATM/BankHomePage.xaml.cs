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
    /// Interaction logic for BankHomePage.xaml
    /// </summary>
    public partial class BankHomePage : Page
    {
        MainWindow home;
        CardAccount userAccount;
        public BankHomePage(CardAccount account, MainWindow context)
        {
            InitializeComponent();
            userAccount = account;
            home = context;
        }

        private void button_option1_Click(object sender, RoutedEventArgs e)
        {
            // Balance inquiry
            home.Content = new BalanceInquiryPage(userAccount, home);
        }

        private void button_option2_Click(object sender, RoutedEventArgs e)
        {
            // Deposit
            home.Content = new DepositHomePage(userAccount, home);
        }

        private void button_option3_Click(object sender, RoutedEventArgs e)
        {
            // Withdraw
            home.Content = new WithdrawHomePage(userAccount, home);
        }

        private void button_option4_Click(object sender, RoutedEventArgs e)
        {
            // Transaction
            home.Content = new TransactionPage(userAccount, home);
        }

        private void button_option5_Click(object sender, RoutedEventArgs e)
        {
            // Print Statement
            home.Content = new PrintStatementPage(userAccount, home);
        }

        private void button_option6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_option7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_option8_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "ATM: Logging out", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                home.Reset();
            }
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "ATM: Logging out", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                home.Reset();
            }           
        }
    }
}
