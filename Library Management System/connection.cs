using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Management_System
{
    class connection
    {
        private static connection instance;
        private connection()
        {
           con = new SqlConnection("Data Source=DESKTOP-TDEO8TC;Initial Catalog=Library_management_system;Integrated Security=True");
        }
        public static SqlConnection con;
        public static connection getInstance()
        {
            if (instance == null)
                instance = new connection();
            return instance;            
        }
    }
}
