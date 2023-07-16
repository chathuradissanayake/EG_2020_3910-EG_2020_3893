using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupproject2.Model
{
    public partial class Student : ObservableObject
    {
        [Key]
        public int studentId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double GPA { get; set; }



    }
}
