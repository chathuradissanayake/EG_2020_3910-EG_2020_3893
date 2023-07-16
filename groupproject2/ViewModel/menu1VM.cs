using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using groupproject2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace groupproject2.ViewModel
{
    public partial class menu1VM : ObservableObject
    {
        [RelayCommand]
        private void AddStudent()
        {
            addstudent windowmenu1 = new addstudent();
            //Application.Current.MainWindow.Close();
            Application.Current.MainWindow = windowmenu1;
            windowmenu1.Show();
        }

    }
}
