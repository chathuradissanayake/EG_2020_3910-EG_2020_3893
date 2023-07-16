using groupproject2.View;
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
using System.Windows.Shapes;
using groupproject2.ViewModel;

namespace groupproject2
{
    /// <summary>
    /// Interaction logic for manu1.xaml
    /// </summary>
    public partial class manu1 : Window
    {
        public manu1()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            addstudent windowmenu1 = new addstudent();
            //Application.Current.MainWindow.Close();
            Application.Current.MainWindow = windowmenu1;
            windowmenu1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            addstudent windowmenu1 = new addstudent();
            //Application.Current.MainWindow.Close();
            Application.Current.MainWindow = windowmenu1;
            windowmenu1.Show();
        }

        private void ItemList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
