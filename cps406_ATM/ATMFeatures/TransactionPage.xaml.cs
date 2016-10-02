using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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
    /// Interaction logic for TransactionPage.xaml
    /// </summary>
    public partial class TransactionPage : Page
    {
        CardAccount userAccount;
        MainWindow home;
        public TransactionPage(CardAccount account, MainWindow context)
        {
            InitializeComponent();
            userAccount = account;
            home = context;
            Database data = new Database();
            DataTable dataTable = data.GetTransactions(account.GetCardNumber());
            dataTransactions.ItemsSource = dataTable.DefaultView;
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            home.Content = new BankHomePage(userAccount, home);
        }

        private void button_option8_Click(object sender, RoutedEventArgs e)
        {
            home.Content = new BankHomePage(userAccount, home);
        }
    }
}
