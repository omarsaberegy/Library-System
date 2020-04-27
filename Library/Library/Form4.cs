using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // to use sql commands
using System.Web;
namespace Library
{
    public partial class Form4 : Form
    {
        // connection with data Base
        SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
        SqlDataAdapter ar;
        SqlDataReader Rd;
        DataSet ds = new DataSet();
        DataTable Dt = new DataTable();

        SqlCommandBuilder scb;

      
        SqlCommand cmd;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure ?!", "Exit Program ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox4.Text = "Books";
            Book Bk = new Book();
            Dt = Bk.Browse_All();
            dataGridView1.DataSource = Dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Book Bk = new Book();
            Bk.Upload_Book(textBox8.Text, textBox7.Text, textBox9.Text, textBox10.Text, Convert.ToDouble(textBox13.Text), Convert.ToInt32(textBox12.Text), textBox11.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
          //  dataGridView1.Rows.Clear();
               dataGridView1.DataSource = null;
            //dataGridView1.ClearSelection();


        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           



        }

        private void button4_Click(object sender, EventArgs e)
        {
       
         

        
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox4.Text = "Reader";
            Reader Rd = new Reader();
            Dt = Rd.Browse_Readers();
            dataGridView1.DataSource = Dt;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            groupBox4.Text = "Librarian";
            Librarian Lb = new Librarian();
            Dt = Lb.Browse_Librarian();
                dataGridView1.DataSource = Dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }











        private void button3_Click(object sender, EventArgs e)
        {
            if (groupBox4.Text == "Books")
            {
                Book Bk = new Book();
                string Title, ISBN, Author, Genere, Location;
                int quantity;
                double Price;

                ISBN = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Title = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Author = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Location = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                quantity = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                Genere = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Price = Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value);

                Bk.Update(ISBN, Title, Author, Location, quantity, Genere, Price);
            }

            else if (groupBox4.Text == "Reader")
            {
                Reader Rd = new Reader();
                int ID;
                int Phone;
                string Password;
                string UserName;
                string Address;
                string Email;
                string Is_Blocked;

                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                UserName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Password = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Email = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Phone = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                Address = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Is_Blocked = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                Rd.Update(ID, UserName, Password, Email, Phone, Address, Is_Blocked);
            }
            else if (groupBox4.Text == "Librarian")
            {
                Librarian Lb = new Librarian();
                int ID;
                int Phone;
                string Password;
                string UserName;
                string Address;
                string Email;

                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                UserName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Password = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Email = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Phone = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                Address = dataGridView1.CurrentRow.Cells[5].Value.ToString();




                Lb.Update(ID, UserName, Password, Email, Phone, Address);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Librarian Lb = new Librarian();
            int columnIndex =   dataGridView1.CurrentCell.ColumnIndex;
            string columnName = dataGridView1.Columns[columnIndex].Name;
            string value = dataGridView1.SelectedRows[0].Cells[columnName].Value.ToString();

           Lb.Delete(groupBox4.Text, columnName, value);
    
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataGridView1.Rows.Remove(row);
            }

            
   }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Book b = new Book();
            if (radioButton2.Checked)
            {
                textBox6.Text = null;
                textBox4.Text = null;
             
                if (textBox5.Text == "")
                {

                }
                else
                {
                    dataGridView1.DataSource = b.search(radioButton2.Text , textBox5.Text);
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Book b = new Book();
            if (radioButton3.Checked)
            {
                textBox4.Text = null;
                textBox5.Text = null;
              
                if (textBox6.Text == "")
                {

                }
                else
                {
                    dataGridView1.DataSource = b.search(radioButton3.Text, textBox6.Text);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            

            Book b = new Book();
            if (radioButton1.Checked)
            {
                textBox6.Text = null;
                textBox5.Text = null;

                if (textBox4.Text == "")
                {

                }
                else
                {
                  
                    dataGridView1.DataSource = b.search(radioButton1.Text, textBox4.Text);
                }
            }
        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Librarian Lb = new Librarian();
            
            if (radioButton4.Checked)
            {
                textBox2.Text = null;
                if (textBox1.Text == "")
                {

                }
                else
                {

                    dataGridView1.DataSource = Lb.search(comboBox1.Text,radioButton4.Text, textBox1.Text);
                }
            
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Librarian Lb = new Librarian();

            if (radioButton5.Checked)
            {
                textBox1.Text = null;

                if (textBox2.Text == "")
                {

                }
                else
                {

                    dataGridView1.DataSource = Lb.search(comboBox1.Text, radioButton5.Text, textBox2.Text);
                }

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
         

        }
 

     
      }






           
        




    }

