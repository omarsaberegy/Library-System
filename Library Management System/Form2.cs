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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            
            textBox2.Visible = false;
            label8.Visible = false;

          
                if (radioButton1.Checked)
                {
                try
                {
                    Librarian Lb = new Librarian();

                    if (textBox2.Text == Lb.serial_no().ToString())
                    {
                        if (Lb.Sign_in(First_Name.Text + " " + Last_Name.Text, Password.Text) == 0)
                        {
                            Lb.Sign_Up(First_Name.Text, Last_Name.Text, Convert.ToInt32(Cell_Phone.Text), Address.Text, Email.Text, Password.Text);
                            MessageBox.Show("Done");
                            textBox2.Clear();
                            Form1 f = new Form1();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("There a person has the the same User name or password change one of them");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("There is empty field");
                }
            }
          
                else if(radioButton2.Checked)
            {
                try
                {
                    Reader Rd = new Reader();
                    if (Rd.Sign_in(First_Name.Text + " " + Last_Name.Text, Password.Text) == 0)
                    {
                        Rd.Sign_Up(First_Name.Text, Last_Name.Text, Convert.ToInt32(Cell_Phone.Text), Address.Text, Email.Text, Password.Text);
                        MessageBox.Show("Done");
                        Form1 f = new Form1();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("There a person has the the same User name or password change one of them");
                    }
               }
                catch(Exception )
                {
                     MessageBox.Show("There is empty field");
                }
            }
                else
            {
                MessageBox.Show("You should select the type of person");
            }
               
            
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            textBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
