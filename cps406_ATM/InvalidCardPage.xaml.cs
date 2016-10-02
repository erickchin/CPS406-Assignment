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
    /// Interaction logic for InvalidCardPage.xaml
    /// </summary>
    public partial class InvalidCardPage : Page
    {
        MainWindow home;
        public InvalidCardPage(MainWindow context)
        {
            InitializeComponent();
            home = context;
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            home.Reset();
        }
    }
}
