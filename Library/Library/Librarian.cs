﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Library
{
    class Librarian:Person
    {
        public void Update(int ID, string UserName, string Password,string Email , int Phone, string Address )
        {
            this.ID = ID;
            this.Phone = Phone;
            this.Password = Password;
            this.UserName = UserName;
            this.Address = Address;
            this.Email = Email;




            SqlConnection cn = new SqlConnection(@"Server= AMR_PC; DataBase=Library ; Integrated Security=true;");

            cn.Open();
           
            SqlCommand cmd = new SqlCommand("update Librarian set Id = '" + this.ID + "' , UserName = '" + this.UserName + "'  ,  Password = '" + this.Password + "' , Email = '" + this.Email + "', CellPhone = '" + this.Phone + "' , Address = '" + this.Address + "' ", cn);
            cmd.ExecuteNonQuery();
            cn.Close();


        }

    }
}
