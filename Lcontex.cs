using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectVB
{
    public class Lcontex:DbContext
    {
        public DbSet<LibraryManagementUsers> libraryManagementUsers { get; set; }

       public DbSet<Account> Accounts { get; set; }
      public  DbSet<Book> Books { get; set; }
     public    DbSet<Staff> Staffs { get; set; }
     public   DbSet<Student> Students { get; set; }
       
        public DbSet<User> users { get; set; }
        public DbSet<Librarian> librairians { get; set; }
        public DbSet<Book_User> Books_Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)


  => optionsBuilder.UseSqlServer("Server=DESKTOP-GVMKD9H\\MSSQLSERVER01;Database=VBlibrary12;Trusted_Connection=True; TrustServerCertificate=True");




    }
}
