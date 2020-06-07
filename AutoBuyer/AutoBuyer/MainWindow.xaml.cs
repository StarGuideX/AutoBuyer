using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoBuyer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private async void Button_Click_3Async(object sender, RoutedEventArgs e)
        {
            JDBuyer.ToNavigate();
            await new BuyerQuartz().CreateAJobAsync();
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            JDBuyer.Login();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            JDBuyer.Close();
            this.Close();
        }

    }
}
