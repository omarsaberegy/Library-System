using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library
{
     
   
   abstract class Person
    {
       DataSet ds1 = new DataSet();
       DataSet ds2 = new DataSet();


  // Attributes
        protected int ID;
        protected int Phone;
        protected string Password;
        protected string Type;
        protected string UserName;
        protected string Address;
        protected string Email;
        protected int? serial_Num;
  // Methods
      public Person()
        {
            ID = 0;
            Phone = 0;
            Password = "";
            Type = "";
            UserName = "";
            Address = "";
            Email = "";
            
        }
       
    /*  public virtual bool Sign_up(string First_Name, string Last_Name, int Phone, string Address, string Email, string Password, string Type , int serial)
        {

            SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
            SqlCommand cmd;


            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Phone = Phone;
            this.Address = Address;
            this.Email = Email;
            this.Password = Password;
            this.Type = Type;
            this.serial_Num = serial;

            cmd = new SqlCommand("Insert into Persons(First_Name,Last_Name,Type,Email,Password,Address,Cell_Phone) values ('" + First_Name + "' ,'" + Last_Name + "' ,'" + Type + "',  '" + Email + "' , '" + Password + "' , '" + Address + "' ,'" + Phone + "'  )", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            return true;
        }*/
           
       public DataTable Browse_Readers ()
           {
               SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
               SqlDataAdapter ar;
               DataTable Dt = new DataTable();
               cn.Open();
               ar = new SqlDataAdapter("Select * From Reader", cn);
               ar.Fill(Dt);

               cn.Close();

               return Dt;

           }
       
       public DataTable Browse_Librarian ()
       {

           SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
           SqlDataAdapter ar;
           DataTable Dt = new DataTable();

           cn.Open();
           ar = new SqlDataAdapter("Select * From Librarian", cn);
           ar.Fill(Dt);
           cn.Close();

           return Dt;
       }


       // manual Search Function
    /*   public DataTable Search_User(string SearchType, string SearchValue ,string Table_name)
           {
               SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
               SqlDataAdapter ar;
               DataTable Dt = new DataTable();

               cn.Open();

               ar = new SqlDataAdapter("Select * From "+Table_name+" where " + SearchType + " = '" + SearchValue + "' ", cn);
               ar.Fill(Dt);

               cn.Close();

               return Dt;

           }*/

      //manual Search Button Code
      /*  Librarian Lb = new Librarian();
            
               if ( radioButton4.Checked)
                {
                  Dt =  Lb.Search_User(radioButton4.Text , textBox1.Text , comboBox1.Text);
                  dataGridView1.DataSource = Dt;
                }
                else if ( radioButton5.Checked)
                {
                    Dt = Lb.Search_User(radioButton5.Text, textBox2.Text, comboBox1.Text);
                    dataGridView1.DataSource = Dt;
                }
       */

       // Automatic Search Function
      public DataView search(string Table_Name , string SearchType, string SearchValue)
      {

          SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");

          cn.Open();
          SqlCommand cmd = cn.CreateCommand();
          cmd.CommandType = CommandType.Text;
          cmd.CommandText = "select * from "+ Table_Name +" where " + SearchType + " like ('" + SearchValue + "%')";
          cmd.ExecuteNonQuery();
          DataTable dt = new DataTable();
          SqlDataAdapter da = new SqlDataAdapter(cmd);
          da.Fill(dt);
          cn.Close();
          return dt.AsDataView();
          
      }

       public void Delete (string Table_Name, string name , string value)
      {
          SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");
           
          cn.Open();
          
        SqlCommand cmd = new SqlCommand( "Delete From " + Table_Name + " where " + name + " = '" + value + "' ",cn);
        cmd.ExecuteNonQuery();  

          cn.Close();
      }

       
    }
}
