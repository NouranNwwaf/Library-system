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
    public partial class RegesterForm : Form
    {
        Lcontex ctx = new Lcontex();
        public RegesterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegesterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox5.Text; //librarian Student 
            string pass = textBox2.Text;

            if (comboBox1.SelectedIndex==0)
            {
                Librarian l = new Librarian();

                l.Regester(name, pass);
                ctx.libraryManagementUsers.Add(l);
                ctx.libraryManagementUsers.Add(l);
                ctx.SaveChanges();

                LibrarianForm mainForm = new LibrarianForm(l.Id);
                mainForm.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex==2)
            {
                Staff l = new Staff();
                l.Dep=textBox3.Text;
                l.Regester(name, pass);
                l.Account=new Account();
                ctx.libraryManagementUsers.Add(l);
               
               ctx.SaveChanges();
 
                UserForm mainForm = new UserForm(l.Id);
                mainForm.Show();
                this.Hide();

            }
            else if (comboBox1.SelectedIndex==1)
            {
                Student l = new Student();
                l.Regester(name, pass);
                l.Class=textBox4.Text;
                l.Account=new Account();
                ctx.libraryManagementUsers.Add(l);
                ctx.SaveChanges();
                UserForm mainForm = new UserForm(l.Id);
                mainForm.Show();

                this.Hide();

            }
           
            }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                label4.Visible=false;
                textBox3.Visible=false;
                label5.Visible=false;
                textBox4.Visible=false;
            }
            else if(comboBox1.SelectedIndex==1)
            {
                label4.Visible=false;
                textBox3.Visible=false;
                label5.Visible=true;
                textBox4.Visible=true;

            }
            else if(comboBox1.SelectedIndex==2)
            {
                label4.Visible=true;
                textBox3.Visible=true;
                label5.Visible=false;
                textBox4.Visible=false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
