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
        PhoneBuyer buyer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            buyer = new PhoneBuyer();
            buyer.Login();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            buyer.ToNavigate();
            buyer.ToClick();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            buyer.Close();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            buyer.ToNavigate();
            for (int i = 0; i < 10000000; i++)
            {
                buyer.ToClick();
                buyer.sss2();
            }
        }

        private void test(object source, ElapsedEventArgs e)
        {
            //if (DateTime.Now.Hour == 14 && DateTime.Now.Minute == 59 && DateTime.Now.Second == 57)
            //{

                
                //buyer.ToClick();
                //buyer.sss2();
                //buyer.ToClick();
                //buyer.sss2();
            // }
        }
    }
}
