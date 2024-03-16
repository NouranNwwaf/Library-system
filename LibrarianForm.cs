using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgectVB
{
    public partial class LibrarianForm : Form
    {
        [Key]
        private int Id;
        Lcontex ctx = new Lcontex();
        public LibrarianForm(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var l = ctx.librairians.Where(l => l.Id==this.Id).Single();
            Book b = new Book() { Title=textBox1.Text, Auther=textBox2.Text, Publication=textBox3.Text,Status="Exist",
                ISBN=Convert.ToInt32(textBox4.Text)
                };
            b.librarian=l;
            ctx.Books.Add(b);
            ctx.SaveChanges();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = ctx.Books.ToList();
            dataGridView1.DataSource=x;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int isbn = Convert.ToInt32(textBox8.Text);
            var x = ctx.Books.Where(x => x.Id==isbn).Single();
            ctx.Books.Remove(x);
            ctx.SaveChanges();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string t = textBox2.Text;
            var x = ctx.Books.Where(x => x.Auther.Equals(t)).ToList();

            dataGridView1.DataSource=x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            var x = ctx.Books.Where(x => x.Title.Equals(t)).ToList();
            dataGridView1.DataSource=x;

          



        }

        private void button7_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox4.Text);
            var x = ctx.Books.Where(x => x.ISBN==t).ToList();
            dataGridView1.DataSource=x;

        }

        private void button8_Click(object sender, EventArgs e)
        { string t = textBox2.Text;
            var v = ctx.Books.Where(v => v.Auther.Equals(t)).ToList();
            MessageBox.Show(v.Count().ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
           var v = ctx.Accounts.Select(v => v.no_borrowed_books).Max();
            var a = ctx.Accounts.Where(a => a.no_borrowed_books==v).Single();

            var u =ctx.users.Where(u=>u.accountId==a.accountId).Select(u=>u.UserName).Single();
            MessageBox.Show(u);
      
        }

        private void button4_Click(object sender, EventArgs e)
        {int t = Convert.ToInt32(textBox5.Text);
            int l = Convert.ToInt32(textBox6.Text);
            int r = Convert.ToInt32(textBox7.Text);

            var y = ctx.users.Where(y => y.Id==t).Single();
            var x = ctx.Accounts.Where(x => x.accountId==y.accountId).Single();
            x.Update_Account(r, l);
           
            ctx.SaveChanges();


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox5.Text);
            var u = ctx.users.Where(u => u.Id==i).Single();
            var x = ctx.Accounts.Where(x => x.accountId==u.accountId).Single();
            x.Calculate_fine();
            ctx.SaveChanges();
            MessageBox.Show(x.fine_amount.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var x = ctx.Accounts.ToList();
           foreach(var y in x)
            { y.Calculate_fine();
            }
            ctx.SaveChanges();
         
            dataGridView1.DataSource=x.Select(x=>x.fine_amount).ToList();
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        { int isbn = Convert.ToInt32(textBox8.Text);
            int x = Convert.ToInt32(textBox5.Text);
            var y = ctx.users.Where(y => y.Id==x).Single();
           var a=ctx.Accounts.Where(a => a.accountId==y.accountId).Single();
            var b = ctx.Books.Where(v => v.Id==isbn).Single();
                b.Return(isbn);
            a.no_returned_books++;
            a.no_borrowed_books--;
            var d = ctx.Books_Users.Where(d => d.user.Id==y.Id).Single();
            d.returnDate=DateTime.Now;

            var ub = ctx.Books_Users.Where(ub => ub.user.Id==x).Single();
            
                if (DateTime.Now>ub.expectedreturnDate)
                { ub.user.Account.no_late_books++; }

            
            ctx.SaveChanges();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
