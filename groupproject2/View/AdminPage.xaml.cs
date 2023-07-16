using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace groupproject2.View
{
    public partial class AdminPage : Window
    {
        private ObservableCollection<Student> students;

        public AdminPage()
        {
            InitializeComponent();

           
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Clear the students collection
            students.Clear();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new student
            Student student = new Student()
            {
            };

            // Add the student to the collection
            students.Add(student);

            // Clear the text boxes
            
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Update the selected student's details
            
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Delete the selected student
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
