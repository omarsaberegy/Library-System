using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Library_Management_System
{
    class Reader:Person
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TDEO8TC;Initial Catalog=Library_management_system;Integrated Security=True");

        public override void Sign_Up(string First_name, string last_name, int CellPhone, string Address, string Email, string Passsword)
        {
            base.Sign_Up(First_name, last_name, CellPhone, Address, Email, Passsword);

            string insertstring = @"insert into Library_management_system.dbo.Reader(Password,First_name,Last_name,Address,CellPhone,Email,User_name) values(@Password,@First_name,@Last_name,@Address,@CellPhone,@Email,@User_name)";

            con.Open();
            SqlCommand com = new SqlCommand(insertstring, con);

            SqlParameter param1 = new SqlParameter("@Password", this.Passsword);
            com.Parameters.Add(param1);
            SqlParameter param2 = new SqlParameter("@First_name", this.First_name);
            com.Parameters.Add(param2);
            SqlParameter param3 = new SqlParameter("@Last_name", this.last_name);
            com.Parameters.Add(param3);
            SqlParameter param4 = new SqlParameter("@Address", this.Address);
            com.Parameters.Add(param4);
            SqlParameter param5 = new SqlParameter("@CellPhone", this.CellPhone);
            com.Parameters.Add(param5);
            SqlParameter param6 = new SqlParameter("@Email", this.Email);
            com.Parameters.Add(param6);
            SqlParameter param7 = new SqlParameter("@User_name", this.First_name + " " + this.last_name);
            com.Parameters.Add(param7);
            com.ExecuteNonQuery();

            con.Close();

        }
        public override int Sign_in(string User_name, string Password)
        {
            this.User_name = User_name;
            this.Passsword = Password;
            SqlCommand SelectCommand = new SqlCommand("Select *from Library_management_system.dbo.Reader  where Password='" + this.Passsword + "'And User_name='" + this.User_name + "';", con);
            SqlDataReader myreader;
            int count = 0;
            con.Open();
            myreader = SelectCommand.ExecuteReader();
            while(myreader.Read())
            {
                count += 1;
            }
            con.Close();
            return count;

        }
        public bool Checking_block_or_not(string User_name,int ID)
        {
            this.User_name = User_name;
            this.ID = ID;
            string is_blocked = "";
            con.Open();
            SqlCommand c = new SqlCommand("select is_blocked from Library_management_system.dbo.Reader where User_name='" + this.User_name + "' and ID='" + this.ID + "'", con);
            SqlDataReader redr = c.ExecuteReader();
            while (redr.Read())
            {
                is_blocked = redr["is_blocked"].ToString();
            }
            redr.Close();
            if(is_blocked=="False")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Data_is_correct(string User_name, int ID)
        {
            this.User_name = User_name;
            this.ID = ID;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TDEO8TC;Initial Catalog=Library_management_system;Integrated Security=True");
            SqlCommand SelectCommand = new SqlCommand("Select *from Library_management_system.dbo.Reader  where ID='" + this.ID + "'And User_name='" + this.User_name + "';", con);
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
        public override List<string> forget_Signin_data(string Email)
        {
            List<string> my_list = new List<string>();
            this.Email = Email;
            string username = "";
            string Password = "";
            con.Open();
            SqlCommand c = new SqlCommand("select User_name from Library_management_system.dbo.Reader where Email='" + this.Email + "' ", con);
            SqlDataReader redr = c.ExecuteReader();
            while (redr.Read())
            {
                username = redr["User_name"].ToString();
            }
            redr.Close();
            SqlCommand c1 = new SqlCommand("select Password from Library_management_system.dbo.Reader where Email='" + this.Email + "'", con);
            SqlDataReader redr1 = c1.ExecuteReader();
            while (redr1.Read())
            {
                Password = redr1["Password"].ToString();
            }
            redr1.Close();
            my_list.Add(username);
            my_list.Add(Password);
            return my_list;
        }
    }
}
