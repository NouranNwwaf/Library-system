using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectVB
{
    public  class Account
    {
        [Key]
        public int accountId { get; set; }
        public int? no_borrowed_books { get; set; }
        public int? no_late_books { get; set; }
        public int? no_returned_books { get; set; }
        public int? no_lost_books { get; set; }
        public double? fine_amount { get; set; }
        public User User { get; set; }
        public Account()
        { 
            no_borrowed_books=0;
            no_late_books=0;
            no_lost_books=0;
            no_returned_books=0;
            fine_amount=0;
        
        }
      
        public void Calculate_fine()
        {
            double fine = Convert.ToDouble(no_late_books*5+no_late_books*3);
            fine_amount=fine;
        }
        public void Update_Account(int lost, int returned)
        { this.no_lost_books=lost; this.no_returned_books=returned; }
       
        public string getInfo()
        {
            return $" #of borrowd {no_borrowed_books} \n #of late books {no_late_books}  #of return books\n {no_returned_books} \n#of lost books {no_lost_books}";

        }
    }
}
