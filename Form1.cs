using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;


namespace ProgectVB
{
    public partial class Form1 : Form
    {
         Lcontex ctx = new Lcontex();

       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string pass = textBox2.Text;

            if (comboBox1.SelectedIndex==0)
            {
                var l = ctx.librairians.ToList();
                bool flag = false;
                foreach (var item in l)
                {
                    if (item.Verify(pass, id)==true)
                    { flag=true; break; }
                }
                if (flag==false) throw new verifyException("this account does not exist");
                else
                {
                    LibrarianForm mainForm = new LibrarianForm(id);
                    mainForm.Show();
                    this.Hide();

                }
            }
            else
            {
                var l = ctx.users.ToList();
                bool flag = false;
                foreach (var item in l)
                {
                    if (item.Verify(pass, id)==true)
                    { flag=true; break; }
                }

                if (flag==false) { throw new verifyException("this account does not exist"); }
                else
                {
                    UserForm mainForm = new UserForm(id);
                    mainForm.Show();
                    this.Hide();

                }

            }

            //private void button2_Click(object sender, EventArgs e)
            //{
            //    string name = textBox5.Text; //librarian Student 
            //    string pass = textBox2.Text;

            //    if (comboBox1.SelectedIndex==0)
            //    {
            //        Librarian l = new Librarian();

            //        l.Regester(name, pass);
            //        ctx.libraryManagementUsers.Add(l);
            //    }
            //    else if (comboBox1.SelectedIndex==2)
            //    {
            //        Staff l = new Staff();
            //        l.Dep=textBox3.Text;
            //        l.Regester(name, pass);
            //        l.Account=new Account();
            //        ctx.libraryManagementUsers.Add(l); }
            //    else if (comboBox1.SelectedIndex==1)
            //    {
            //        Student l = new Student();
            //        l.Regester(name, pass);
            //        l.Class=textBox4.Text;
            //        l.Account=new Account();
            //        ctx.libraryManagementUsers.Add(l);


            //    }
            //    ctx.SaveChanges();

            //}
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegesterForm mainForm = new RegesterForm();
            mainForm.Show();
            this.Hide();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

        //private void Form1_Load_1(object sender, EventArgs e)
        //{

        //}
    }