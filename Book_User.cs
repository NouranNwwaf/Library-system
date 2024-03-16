using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgectVB
{
    public class Book_User
    {public int id { get; set; }
        public DateTime borrowDate { get; set; }
        public DateTime returnDate { get; set; }
        public DateTime expectedreturnDate { get; set; }
     
        public User? user { get; set; }

        public Book? Book { get; set; }
    }
}
