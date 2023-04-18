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

namespace CS_Timewaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        string phoneNumber = "";
        string nextNumber = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            phoneNumberLabel.Content = "";
            nextNumberLabel.Content = "";
            phoneNumber = "";

            MakeGuess();
        }

        private void MakeGuess()
        {
            Console.WriteLine("dsd");
            int number = new Random().Next(0, 10);
            nextNumber = number.ToString();
            nextNumberLabel.Content = nextNumber;
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            //Correct number, add to phone num
            phoneNumber = phoneNumber + nextNumber;
            phoneNumberLabel.Content = phoneNumber;
            MakeGuess();
        }

        private void noButton_Click(object sender, RoutedEventArgs e)
        {
            MakeGuess();
        }
    }
}
