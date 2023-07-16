using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace groupproject2.ViewModel
{
    public partial class LoginVM : ObservableObject
    {
        [ObservableProperty]
        public string username;

        [ObservableProperty]
        public string password;

        public readonly DataContext dbContext;

        public LoginVM()
        {
            dbContext = new DataContext();
        }
        public LoginVM(DataContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [RelayCommand]
        private void UserLogin()
        {
            var user = dbContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Window window;

                if (user.Isadmin)
                {
                    window = new manu1();
                }
                else
                {
                    window = new manu1();
                }

                //Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
                window.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
