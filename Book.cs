using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgectVB.Librarian;

namespace ProgectVB
{
    public class Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        [Key]
        int BookId { get; set; }
        public int ISBN { get; set; }
        public String Publication { get; set; }
        public String Status { get; set; }//status:true=borrowed false =exist
        public int Id { get; set; }
        public Librarian? librarian { get; set; }
       

        public ICollection<User> Users { get; set; }


        public void Update_Status()
        {
            if (Status=="Borrowed") Status="Exist";
            else Status="Borrowed";
        }
        public void Borrow(int isbn)
        {
            if (Status.Equals("Borrowed")) throw new verifyException("Sorry,but this book does not exist currently");
            else
            {
                Update_Status();

            }
        }
public void Return(int isbn)
        {
            if (Status.Equals("Exist")) throw new verifyException("thi book already exist");
            else
            {
                Update_Status();

            }
        }
        public string getBookInfo()

        { return $"Title {Title}\nISBN  {ISBN} \n Puvlication {Publication}\n status {Status} \nAuther {Auther}"; }
    }
}
