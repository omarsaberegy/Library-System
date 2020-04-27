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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Signuptxt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
          

        }

        private void SignIntxt_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label8.Visible = false;
            if (radioButton2.Checked)
            {
                try
                {
                    Reader R = new Reader();
                    
                    if(R.Sign_in(UserNametxt.Text,Passwordtxt.Text)==1)
                    {

                        this.Hide();
                        Form3 F = new Form3();
                        F.Show();
                    }
                    else if(R.Sign_in(UserNametxt.Text, Passwordtxt.Text) >1)
                    {
                        MessageBox.Show("Dupliacate Data");
                    }
                    else
                    {
                        MessageBox.Show("Data is incorrect");
                    }
                    
                }
                catch(Exception)
                {
                   MessageBox.Show("Some field is empty");
                }
            }
            else if(radioButton1.Checked)
            {
                try
                {

                    Librarian l = new Librarian();
                    if (textBox2.Text == l.serial_no().ToString())
                    {
                        if (l.Sign_in(UserNametxt.Text, Passwordtxt.Text) == 1)
                        {
                            textBox2.Clear();
                            this.Hide();
                            Form4 F = new Form4();
                            F.Show();
                        }
                        else if (l.Sign_in(UserNametxt.Text, Passwordtxt.Text) > 1)
                        {
                            MessageBox.Show("Dupliacate Data");
                        }
                        else
                        {
                            MessageBox.Show("Data is incorrect");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect serial number");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Some field is empty");
                }
               
            }
            else
            {
               
                MessageBox.Show("You should choose the type");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            textBox2.Visible = true;
        }

        private void Exittxt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure ?!", "Exit Program ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            forgetmaillabel.Visible = true;
            forgetmailtext.Visible = true;
            radioButton3.Visible = true;//Reader
            radioButton4.Visible = true;//Librarian
            button2.Visible = true;

}

        private void button2_Click(object sender, EventArgs e)
        {

            Reader r = new Reader();
            Librarian l = new Librarian();
            try
            {
                List<string> Li = new List<string>();
                if (radioButton3.Checked)
                {

                    Li = r.forget_Signin_data(forgetmailtext.Text);
                    string user_name = Li[0];
                    string Password = Li[1];
                    if (Password == "" && user_name == "")
                    {
                        MessageBox.Show("Entered mail is incorrect");
                    }

                    else
                    {
                        MessageBox.Show("You user name is : " + user_name + "/ " + "Your password is : " + Password);
                    }
                }
                else if (radioButton4.Checked)
                {
                    Li = l.forget_Signin_data(forgetmailtext.Text);
                    string user_name = Li[0];
                    string Password = Li[1];
                    if (Password == "" && user_name == "")
                    {
                        MessageBox.Show("Entered mail is incorrect");
                    }

                    else
                    {
                        MessageBox.Show("You user name is : " + user_name + "/ " + "Your password is : " + Password);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You forget to select required data");
            }
            forgetmaillabel.Visible = false;
            forgetmailtext.Visible = false;
            radioButton3.Visible = false;//Reader
            radioButton4.Visible = false;//Librarian
            button2.Visible = false;
        }
    }
}
