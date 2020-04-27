using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // to use sql commands
using System.Data;

namespace Library
{
    class Book
    {
        protected string Title;
        protected string ISBN;
        protected string Author;
        protected string Genere;
        protected double Price;
        protected int Quantity ;
        protected string Location;


        public Book ()
        {
            Title = "";
            ISBN = "";
            Author = "";
            Genere = "";
            Price = 0.0;
            Quantity = 0;
            Location = "";
        }

        public void Upload_Book(string Title, string ISBN, string Author, string Genere, double Price, int Quantity ,  string Location)
        {

            SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
            SqlCommand cmd;

            cn.Open();
            cmd = new SqlCommand("Insert into Books (ISBN,Title,Author,Location,Quantity,Genere,Price) values ('" + ISBN + "', '" + Title + "' , '" + Author + "' , '" + Location + "' , '" + Convert.ToInt32(Quantity) + "' , '" + Genere + "' , '" + Convert.ToDouble(Price) + "'  )", cn);
       
            cmd.ExecuteNonQuery();
            cn.Close();

        }                   

        public DataTable Browse_All()
        {
            SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
            SqlDataAdapter ar;
            DataTable Dt = new DataTable();


            cn.Open();
            ar = new SqlDataAdapter("Select * From Books", cn);
            ar.Fill(Dt);

           
            cn.Close();

            return Dt;
        }

        // Manual search function
      /*  public DataTable Search_Book(string SearchType, string SearchValue)
        {
            SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
            SqlDataAdapter ar;
            DataTable Dt = new DataTable();
      
            cn.Open();

            ar = new SqlDataAdapter("Select * From Books where "+SearchType+" = '"+ SearchValue +"' ", cn);
            ar.Fill(Dt);
            
            cn.Close();

          return Dt;

        }*/
        // Manual Search Button code
         /*  Book Bk = new Book();
        if (radioButton1.Checked)
            {
                Dt = Bk.Search_Book(radioButton1.Text, textBox4.Text);
                dataGridView1.DataSource = Dt;
            }

        else if (radioButton2.Checked)
        {
            Dt = Bk.Search_Book(radioButton2.Text, textBox5.Text);
            dataGridView1.DataSource = Dt;
        }

        else if (radioButton3.Checked)
            {
                Dt = Bk.Search_Book(radioButton3.Text, textBox6.Text);
                dataGridView1.DataSource = Dt;
            }*/
        // Automatic Search
        public DataView search(string SearchType , string SearchValue)
        {

            SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");

            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Books where "+SearchType+" like ('" + SearchValue + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt.AsDataView();
          
        }



        public void Update(string ISBN, string Title , string Author , string Location , int Quantity , string Genere, double Price )
                        
        {
            this.Title = Title;
            this.ISBN = ISBN;
            this.Author = Author;
            this.Genere = Genere;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Location = Location;

            SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
                          
            cn.Open();
            SqlCommand cmd = new SqlCommand(" update Books set ISBN = '"+this.ISBN+"' , Title = '"+this.Title+"' , Author = '"+this.Author+"' , Location = '"+this.Location+"' , Quantity = '"+this.Quantity+"' , Genere = '"+this.Genere+"' , Price = '"+this.Price+"'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();

        }

    }
}
