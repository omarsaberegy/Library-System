using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Reader r = new Reader();
                loan l = new loan(usernamereturn.Text, Convert.ToInt32(textBox1.Text));
                if (r.Data_is_correct(usernamereturn.Text, Convert.ToInt32(textBox1.Text)) != 0)
                {

                    if (l.Check_data_is_true_in_request(ISBNForreturnBook.Text) != 0)
                    {
                        if(l.return_book(ISBNForreturnBook.Text))
                        {
                            MessageBox.Show("You return book in the time");
                        }
                        else
                        {
                            MessageBox.Show("Ufortunatly you blocked due to late in return book");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There are an error of request data you entered");
                    }
                }
                else
                {
                    MessageBox.Show("Data of reader is in correct");
                }
            }
            catch (Exception)
            {

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
