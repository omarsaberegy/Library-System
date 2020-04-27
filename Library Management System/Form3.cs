using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Library_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Book b = new Book();
            if (textBox2.Text == "")
            {

            }
            else
            {
                dataGridView1.DataSource = b.search(textBox2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Reader r = new Reader();
                context c = new context();
                loan l = new loan(usernametxt.Text, Convert.ToInt32(ReaderIDtxt.Text));
                c.Setstrategy(new loan(usernametxt.Text, Convert.ToInt32(ReaderIDtxt.Text)));
                if (r.Data_is_correct(usernametxt.Text, Convert.ToInt32(ReaderIDtxt.Text)) == 1)
                {
                    if (l.Check_data_is_true_in_request(ISBNtxt.Text) == 0)
                    {
                        if (r.Checking_block_or_not(usernametxt.Text, Convert.ToInt32(ReaderIDtxt.Text)))
                        {
                            if (c.Execute_strategy(ISBNtxt.Text))
                            {
                                MessageBox.Show("Done");

                            }
                            else
                            {
                                MessageBox.Show("Unfortunately there are no copies from this book");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unfortunately you are blocked");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is the same data for current request");
                    }
                }
                else
                {
                    MessageBox.Show("Error in Data you entered");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You forget to enter some data");
            }

        }

       

       

        private void Form3_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                context c = new context();
                c.Setstrategy(new Buy());
               
                if (c.Execute_strategy(textBox4.Text))
                {
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Error in Data or book is Not available to buy  or there no copies for ths book");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
