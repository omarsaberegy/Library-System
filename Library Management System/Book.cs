using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Library_Management_System
{
    class Book
    {
        string ISBN;
        string Title;
        string Auther;
        string Location;
        int No_of_copies;
        string Genre;
        double Price;
        public DataView search(string Title)
        {
            try
            {
                this.Title = Title;
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TDEO8TC;Initial Catalog=Library_management_system;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from Library_management_system.dbo.Book where Title like ('" + this.Title + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt.AsDataView();
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
          
        }

    }
}
