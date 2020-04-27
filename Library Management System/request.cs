using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Library_Management_System
{
   abstract class request
    {
        protected  string isbn;
        protected DateTime Request_date;
        protected DateTime Due_date;
        protected string user_name;
        protected int user_id;
        public abstract bool make_request(string ISBN);
    }
    class Buy : request
    {
       

        public override bool make_request(string isbn)
        {
            try
            {
                int No_of_copies = 0;
                string Availabilty = "";
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TDEO8TC;Initial Catalog=Library_management_system;Integrated Security=True");
                this.isbn = isbn;
                con.Open();
                SqlCommand cmd = new SqlCommand("select No_of_copies from Library_management_system.dbo.Book where ISBN='" + this.isbn + "'", con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    No_of_copies = Convert.ToInt32(rdr["No_of_copies"]);
                }
                rdr.Close();
                SqlCommand c = new SqlCommand("select Availabilty_to_buy from Library_management_system.dbo.Book where ISBN='" + this.isbn + "'", con);
                SqlDataReader redr = c.ExecuteReader();
                while (redr.Read())
                {
                    Availabilty = redr["Availabilty_to_buy"].ToString();
                }
                redr.Close();
                if (No_of_copies != 0)
                {
                    if (Availabilty == "Available")
                    {

                        string Updatestring = @"update Library_management_system.dbo.Book set No_of_copies=@No_of_copies where ISBN='" + this.isbn + "'";
                        SqlCommand s = new SqlCommand(Updatestring, con);
                        SqlParameter para = new SqlParameter("@No_of_copies", --No_of_copies);
                        s.Parameters.Add(para);
                        s.ExecuteNonQuery();
                        con.Close();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
    }
    class loan : request
    {
        public loan(string user_name, int user_id)
        {
            this.user_name = user_name;
            this.user_id = user_id;
            Request_date = DateTime.Now;
            Due_date = Request_date.AddDays(14);
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TDEO8TC;Initial Catalog=Library_management_system;Integrated Security=True");

        public override bool make_request(string isbn)
        {
            try
            {


                this.isbn = isbn;
              
                int No_of_copies = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("select No_of_copies from Library_management_system.dbo.Book where ISBN='" + this.isbn + "' ", con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    No_of_copies = Convert.ToInt32(rdr["No_of_copies"]);
                }
                rdr.Close();
             
                    if (No_of_copies != 0)
                    {

                        string insertstring = @"insert into Library_management_system.dbo.Request(ISBN,Reader_ID,Request_date,Due_date) values(@ISBN,@Reader_ID,@Request_Date,@Due_date)";

                        SqlCommand com = new SqlCommand(insertstring, con);

                        SqlParameter param1 = new SqlParameter("@ISBN", this.isbn);
                        com.Parameters.Add(param1);
                        SqlParameter param2 = new SqlParameter("@Reader_ID", this.user_id);
                        com.Parameters.Add(param2);
                        SqlParameter param3 = new SqlParameter("@Request_date", this.Request_date);
                        com.Parameters.Add(param3);
                        SqlParameter param4 = new SqlParameter("@Due_date", this.Due_date);
                        com.Parameters.Add(param4);
                        com.ExecuteNonQuery();
                        string Updatestring = @"update Library_management_system.dbo.Book set No_of_copies=@No_of_copies where ISBN='" + this.isbn + "'";
                        SqlCommand s = new SqlCommand(Updatestring, con);
                        SqlParameter para = new SqlParameter("@No_of_copies", --No_of_copies);
                        s.Parameters.Add(para);
                        s.ExecuteNonQuery();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

             
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int Check_data_is_true_in_request(string isbn)
        {

            this.isbn = isbn;
            SqlCommand SelectCommand = new SqlCommand("Select *from Library_management_system.dbo.Request  where ISBN='" + this.isbn + "'And Reader_ID='" + this.user_id + "';", con);
            SqlDataReader myreader;
            int count = 0;
            con.Open();
            myreader = SelectCommand.ExecuteReader();
            while (myreader.Read())
            {
                count += 1;
            }
            con.Close();
            return count;
        }
        public bool return_book(string isbn)
        {
            DateTime d = DateTime.Now;
            DateTime duedate = new DateTime();
            con.Open();
            SqlCommand SelectCommand = new SqlCommand("Select Due_date from Library_management_system.dbo.Request  where ISBN='" + this.isbn + "'And Reader_ID='" + this.user_id + "';", con);
            SqlDataReader redr = SelectCommand.ExecuteReader();
            while (redr.Read())
            {
                duedate = Convert.ToDateTime( redr["Due_date"]);
            }
            redr.Close();
            SqlCommand Delete = new SqlCommand("delete from Library_management_system.dbo.Request where ISBN='" + this.isbn + "' And Reader_ID='" + this.user_id + "';", con);
            Delete.ExecuteNonQuery();
            int No_of_copies = 0;

            SqlCommand cmd = new SqlCommand("select No_of_copies from Library_management_system.dbo.Book where ISBN='" + this.isbn + "' ", con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                No_of_copies = Convert.ToInt32(rdr["No_of_copies"]);
            }
            rdr.Close();
            string Updatestring = @"update Library_management_system.dbo.Book set No_of_copies=@No_of_copies where ISBN='" + this.isbn + "'";
            SqlCommand s = new SqlCommand(Updatestring, con);
            SqlParameter para1 = new SqlParameter("@No_of_copies", ++No_of_copies);
            s.Parameters.Add(para1);
            s.ExecuteNonQuery();
            if (d>duedate)
            {
                string is_blocked = "True";
               
                SqlCommand update = new SqlCommand("update Library_management_system.dbo.Reader set is_blocked=@is_blocked where User_name='" + this.user_name + "'And ID='"+this.user_id+"';", con);
                SqlParameter para = new SqlParameter("@is_blocked", is_blocked);
                update.Parameters.Add(para);
                update.ExecuteNonQuery();
               
                return false;
            }
            else 
            {
                return true;
            }
        }
        
    }
    class context
    {
        request obj;
        public void Setstrategy(request obj)
        {
            this.obj = obj;
        }
        public bool Execute_strategy(string ISBN)
        {
           return obj.make_request(ISBN);
        }
       
    }
    
}
