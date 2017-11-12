using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Information.Store
{
    public class DatabaseHelper
    {
        public static string GetConnectionString()
        {
            return "Data Source=FAMILYPC01;Initial Catalog=Dvd;Integrated Security=True";
        }

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            return conn;
        }
    }
}
