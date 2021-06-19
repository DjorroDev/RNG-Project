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

namespace RNG_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Random r = new();
        int n;
        string c;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (oneDigit.IsChecked == true)
            {
                n = r.Next(1, 9);
                Result.Content = n.ToString();

            }
            else if (twoDigits.IsChecked == true)
            {
                n = r.Next(10, 99);
                Result.Content = n.ToString();
            }
            else if (threeDigits.IsChecked == true)
            {
                n = r.Next(100, 999);
                Result.Content = n.ToString();
            }
            else if (fourDigits.IsChecked == true)
            {
                n = r.Next(1000, 9999);
                Result.Content = n.ToString();
            }
            else if (fiveDigits.IsChecked == true)
            {
                n = r.Next(10000, 99999);
                Result.Content = n.ToString();
                
            }
            else if (sixDigits.IsChecked == true)
            {
                n = r.Next(100000, 999999);
                Result.Content = n.ToString();
            }
        }

        //copying to clipboard
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            c = Convert.ToString(Result.Content);
            Clipboard.SetText(c);
        }


    }
}
