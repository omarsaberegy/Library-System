using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlClient;
namespace Library_Management_System
{
   abstract class Person
    {
        protected int ID;
        protected string Passsword;
        protected string Type;
        protected string First_name;
        protected string last_name;
        protected string Address;
        protected int CellPhone;
        protected string Email;
        protected string User_name;

          public virtual void Sign_Up(string First_name, string last_name, int CellPhone, string Address, string Email, string Passsword)
        {
            this.First_name = First_name;
            this.last_name = last_name;
            this.CellPhone = CellPhone;
            this.Address = Address;
            this.Email = Email;
            this.Passsword = Passsword;
           
        }
        public abstract int Sign_in(string User_name, String Password);
        public abstract List<string> forget_Signin_data(string Email);
        
       
    }
}
