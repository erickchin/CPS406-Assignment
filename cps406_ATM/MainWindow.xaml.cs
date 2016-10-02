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
using System.Diagnostics;

namespace cps406_ATM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string cardNum;
        Database data = new Database();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_insertCard_Click(object sender, RoutedEventArgs e)
        {
            cardNum = "4502333344445555";
            if (data.ValidateCard(cardNum))
            {
                PasswordPage page = new PasswordPage(cardNum, this);
                this.Content = page;
            }
            else
            {
                this.Content = new InvalidCardPage(this);
            }
        }

        private void button_insertCard2_Click(object sender, RoutedEventArgs e)
        {
            cardNum = "5502333344445555";
            if (data.ValidateCard(cardNum))
            {
                PasswordPage page = new PasswordPage(cardNum, this);
                this.Content = page;
            }
            else
            {
                this.Content = new InvalidCardPage(this);
            }
        }

        private void button_insertCard3_Click(object sender, RoutedEventArgs e)
        {
            cardNum = "5552333344445555";
            if (data.ValidateCard(cardNum))
            {
                PasswordPage page = new PasswordPage(cardNum, this);
                this.Content = page;
            }
            else
            {
                this.Content = new InvalidCardPage(this);
            }
        }

        public void Reset()
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
