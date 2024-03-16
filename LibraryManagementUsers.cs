using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectVB
{
    public  class LibraryManagementUsers
    {
        public string? UserName { get; set; }

        public string? UserPassword { get; set; }
        public int Id { get; set; }

       

        public void Regester(string userName, string userPassword)
        {
            this.UserName=userName; this.UserPassword=userPassword;
        }
       
      
    }
}
