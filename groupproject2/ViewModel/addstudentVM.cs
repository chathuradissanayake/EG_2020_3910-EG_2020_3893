using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommunityToolkit.Mvvm.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Security.Policy;
using groupproject2.View;

namespace groupproject2.ViewModel
{
    public partial class addstudentVM : ObservableObject
    {
        [ObservableProperty]
        public string name;
      
        [ObservableProperty]
        public int register_no;

          

        public addstudentVM()
        {

        }
        public addstudentVM(Student student)
        {
            name = student.Name;
            register_no = student.Id;

           
        }
    }
}
