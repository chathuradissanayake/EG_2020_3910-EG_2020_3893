using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows;
using groupproject2.Model;
using groupproject2.ViewModel;

namespace groupproject2
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
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle the close button click event here
            Close(); // Example: Close the window
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var Username = UseNameTexts.text;
        //    var Password = PasswordText
        //}




    }
}
