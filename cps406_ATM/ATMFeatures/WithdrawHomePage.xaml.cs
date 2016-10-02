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
    /// Interaction logic for WithdrawHomePage.xaml
    /// </summary>
    public partial class WithdrawHomePage : Page
    {
        CardAccount userAccount;
        MainWindow home;
        public WithdrawHomePage(CardAccount account, MainWindow context)
        {
            InitializeComponent();
            userAccount = account;
            home = context;
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            home.Content = new BankHomePage(userAccount, home);
        }

        private void button_option1_Click(object sender, RoutedEventArgs e)
        {
            // Checkings
            home.Content = new WithdrawPage(userAccount, "Checkings", home);
        }

        private void button_option2_Click(object sender, RoutedEventArgs e)
        {
            // Savings
            home.Content = new WithdrawPage(userAccount, "Savings", home);
        }

        private void button_option8_Click(object sender, RoutedEventArgs e)
        {
            home.Content = new BankHomePage(userAccount, home);
        }
    }
}
