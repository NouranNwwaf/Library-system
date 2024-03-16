using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgectVB
{
    public partial class UserForm : Form
    {
private int Id;
        Lcontex ctx = new Lcontex();
        public UserForm(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var l = ctx.users.Where(l => l.Id==this.Id).Single();
            //var x = ctx.Accounts.Where(x => x.accountId==l.accountId).ToList();
            //dataGridView1.DataSource=x;
            var x = ctx.Accounts.Where(x => x.accountId==l.accountId).Single();
            richTextBox1.Text=x.getInfo();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            var x=ctx.Books.Where(x=>x.ISBN==i).Single();
            richTextBox1.Text=x.getBookInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            var l = ctx.users.Where(l => l.Id==this.Id).Single();
            var s = ctx.Books.Where(s => s.ISBN==i).Single();
            Book_User bu = new Book_User();
           
            s.Borrow(i);
            
            l.Account=ctx.Accounts.Where(x=>x.accountId==l.accountId).Single();
            l.Account.no_borrowed_books++;
            

            
         
            bu.borrowDate=DateTime.Now;
            bu.expectedreturnDate = bu.borrowDate.AddDays(30);
           
            
            bu.Book=s;
            bu.user=l;
            bu.expectedreturnDate = bu.borrowDate.AddDays(30);
            

            ctx.Books_Users.Add(bu);
            ctx.SaveChanges();



           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
