using groupproject2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupproject2.ViewModel
{
    public class DataContext: DbContext
    { 
       
        public string path = @"F:\GUI Project\Group\Save Files\Group Project 3.3\Database.db";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source = {path}");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
//database connetion