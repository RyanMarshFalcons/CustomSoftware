using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dvd.Store
{
    public static class DatabaseHelper
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
