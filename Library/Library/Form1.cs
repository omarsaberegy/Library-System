using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;    // to access the position where the linked label refer to
using System.Data.SqlClient; // to use sql commands
namespace Library
{



    public partial class Form1 : Form
    {
        // connection with data Base
        SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");

       // SqlConnection cn = new SqlConnection("Data Source= AMR_PC ;Initial Catalog=Library;Integrated Security=SSPI ;"); 

        // command make you do any action on data base ( insert _ update - delete _ bring data ) 
        SqlCommand cmd;
        // reader : let you read any data come from data base
        SqlDataReader Rd;

            
        public Form1()
        {
            InitializeComponent();

          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form4 frm = new Form4();
            frm.ShowDialog();

        /*    cmd = new SqlCommand("Select First_Name,Last_Name,Type,Password  From Persons", cn);
            cn.Open();
            Rd = cmd.ExecuteReader();

            bool IS_EXIST = true;

            while ( Rd.Read())
            {

                if (Rd["First_Name"].ToString() == First_Name.Text)
                {
                   
                    //cmd = new SqlCommand("Select Last_Name,Type,Password From Persons", cn);
                    if (Rd["Last_Name"].ToString() == Last_Name.Text && Rd["Password"].ToString() == Password.Text && Rd["Type"].ToString() == Type.Text )
                    {
                        IS_EXIST = true;
                        MessageBox.Show("Data Recognized ......", "Person Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        Form4 frm = new Form4();
                        frm.ShowDialog();



                        break;
                    }
                    
                    
                }
                else
                {
                    IS_EXIST = false;
                    continue;
                }
                    
            }

            if ( IS_EXIST == false)
                MessageBox.Show("Cannot Find User_Name OR Password .....", "Person Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                Rd.Close();
                cn.Close();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are You Sure ?!", "Exit Program ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult result = MessageBox.Show("Are You Sure ?!", "Exit Program ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.google.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.libraryBooks.com");
        }

        private void First_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();


            Form2 frm = new Form2();
            //frm.Show();
            frm.ShowDialog();

         //   this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
