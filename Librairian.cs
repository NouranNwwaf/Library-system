using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectVB
{
    
        public class Librarian : LibraryManagementUsers
        {
       
            
            public bool Verify(string pass, int id)
            {
                if (pass.Equals(this.UserPassword)&&this.Id==id) return true;
                return false;

            }
            public ICollection<Book> Books { get; set; } 
        public string print()
    { return "yaaaa rab"; }
}

        }
  
