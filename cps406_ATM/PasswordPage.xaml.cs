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
    /// Interaction logic for PasswordPage.xaml
    /// </summary>
    public partial class PasswordPage : Page
    {
        string pin = "";
        string label = "";
        int trials = 3;
        MainWindow home;
        string cardNumber;

        public PasswordPage(string card_number, MainWindow context)
        {
            InitializeComponent();
            home = context;
            cardNumber = card_number;
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length < 4)
            {
                pin += "1";
                label += "*";
                labelPin.Content = label;
            }
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length < 4)
            {
                pin += "2";
                label += "*";
                labelPin.Content = label;
            }
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length < 4)
            {
                pin += "3";
                label += "*";
                labelPin.Content = label;
            }
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length < 4)
            {
                pin += "4";
                label += "*";
                labelPin.Content = label;
            }
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length < 4)
            {
                pin += "5";
                label += "*";
                labelPin.Content = label;
            }
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length < 4)
            {
                pin += "6";
                label += "*";
                labelPin.Content = label;
            }
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length < 4)
            {
                pin += "7";
                label += "*";
                labelPin.Content = label;
            }
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length < 4)
            {
                pin += "8";
                label += "*";
                labelPin.Content = label;
            }
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length < 4)
            {
                pin += "9";
                label += "*";
                labelPin.Content = label;
            }
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length < 4)
            {
                pin += "0";
                label += "*";
                labelPin.Content = label;
            }
        }

        private void button_enter_Click(object sender, RoutedEventArgs e)
        {
            if (pin.Length == 4)
            {
                CardAccount account = new CardAccount();
                bool correctPin = account.VerifyPin(cardNumber, pin);
                if (correctPin)
                {
                    home.Content = new BankHomePage(account, home);
                }
                else
                {
                    trials--;
                    pin = "";
                    label = "";
                    labelPin.Content = "";
                    labelStatus.Content = "Error! Wrong pin. " + trials + " left.";
                    if (trials == 0)
                    {
                        home.Reset();
                    }
                }
            }
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            pin = "";
            label = "";
            labelPin.Content = "";
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            home.Reset();
        }
    }
}
