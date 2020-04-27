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

namespace Library
{
    public partial class Form2 : Form
    {

        SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
        SqlCommand cmd;
        SqlDataReader Rd;
        SqlDataAdapter Ar;

        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
           
/*
            if (radioButton1.Checked)
            {
                Librarian LB = new Librarian();
                try
                {
                    
                    
                    bool Checking = LB.Sign_up(First_Name.Text, Last_Name.Text, Convert.ToInt32(Cell_Phone.Text), Address.Text, Email.Text, Password.Text, radioButton1.Text , Convert.ToInt32(textBox2.Text));

                    if (Checking == true )
                    {
                        MessageBox.Show("Account Created Successfully ....", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form1 frm = new Form1();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Some Errors had occured ....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                        Form1 frm = new Form1();
                        frm.ShowDialog();
                    }

                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Some Errors had occured ...." + ex.Message);
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                }


                finally
                {
                    cn.Close();
                }

            }*/
        }
        
        
        
        
 
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            textBox2.Visible = true; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Are You Sure ?!", "Exit Program ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
