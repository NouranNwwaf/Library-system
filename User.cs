using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProgectVB
{
    public  class User:LibraryManagementUsers
    {        public int accountId { get; set; }

        public Account? Account { get; set; }

        public ICollection<Book> Books { get; set; }

        

        public bool Verify(string pass, int id)
        {
            if (pass.Equals(this.UserPassword)&&this.Id==id) return true;
            return false;
        }


        public string CheckAccount()
        { return Account.getInfo(); }
        public string get_book_info(int isbn)
        {
            foreach (Book b in Books)
                if (isbn==b.ISBN)
                    return b.getBookInfo();
                else return "the book dose not exist";
            return "";

        }
       
    }
}
