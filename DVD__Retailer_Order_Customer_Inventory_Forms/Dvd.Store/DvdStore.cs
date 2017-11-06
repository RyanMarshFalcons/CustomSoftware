using Dvd.Data.Interfaces.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dvd.Data.Model;
using System.Data.SqlClient;
using System.Data;

namespace Dvd.Store
{
    public class DvdStore : IDvdStore
    {
        #region Constant Strings
        private const string SQL_SELECT =
            "SELECT DVD_ID, Title, Genre, QuantityInStock, SalesPrice, PurchasePrice, IsDeleted "
        + "FROM [dbo].[DVD] "
        + "WHERE IsDeleted = 0 ";


        private const string SQL_SELECT_ROW =
            SQL_SELECT + "AND DVD_ID = @DVD_Id ";

        private const string SQL_INSERT = "INSERT INTO [dbo].[DVD] "
            + "([DVD_ID],[Title],[Genre],[QuantityInStock],[SalesPrice],[PurchasePrice], [IsDeleted]) "
            + "VALUES "
            + "(@DVD_ID, @Title, @Genre, @QuantityInStock, @SalesPrice, @PurchasePrice, @IsDeleted); "
            + "SELECT @@IDENTITY ";

        private const string SQL_UPDATE =
                "UPDATE [dbo].[DVD] "
                + "SET DVD_ID = @DVD_ID, "
                + "Title = @Title, "
                + "Genre = @Genre, "
                + "QuantityInStock = @QuantityInStock, "
                + "SalesPrice = @SalesPrice, "
                + "PurchasePrice = @PurchasePrice, "
                + "IsDeleted = @IsDeleted ";

        private const string SQL_DELETE =
                "UPDATE [dbo].[DVD] "
                + "SET IsDeleted = 1 "
                + "WHERE DVD_ID = @DVD_ID ";

        private const string SQL_VERIFY_EXISTS =
            "SELECT COUNT(1) "
            + "FROM [dbo].[DVD] "
            + "WHERE DVD_ID = @DVD_ID ";
        #endregion

        public int AddDVD(DVD dvd)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.Add("@Title", SqlDbType.VarChar, 50).Value = dvd.Title;
                    cmd.Parameters.Add("@Genre", SqlDbType.VarChar, 50).Value = dvd.Genre;
                    cmd.Parameters.Add("@QuantityInStock", SqlDbType.VarChar, 50).Value = dvd.QuantityInStock;
                    cmd.Parameters.Add("@SalesPrice", SqlDbType.VarChar, 50).Value = dvd.SalesPrice;
                    cmd.Parameters.Add("@PurchasePrice", SqlDbType.VarChar, 50).Value = dvd.PurchasePrice;

                    conn.Open();
                    var id = cmd.ExecuteScalar();
                    return Convert.ToInt32(id);
                }
            }
        }

        public int DeleteDVD(int dvd_ID)
        {
            var rowsAffected = 0;
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_DELETE, conn))
                {
                    cmd.Parameters.Add("@DVD_ID", SqlDbType.Int).Value = dvd_ID;
                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public DVD GetDVD(int dvd_ID)
        {
            var dvd = new DVD();
            using (var conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(SQL_SELECT_ROW, conn);
                cmd.Parameters.Add("@DVD_ID", SqlDbType.Int).Value = dvd_ID;

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    AssignColumnValues(rdr, dvd);
                }
            }
            return dvd;
        }

        public List<DVD> GetDVDs()
        {
            var items = new List<DVD>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(SQL_SELECT, conn);

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var item = new DVD();
                    AssignColumnValues(rdr, item);
                    items.Add(item);
                }
            }
            return items;
        }

        public int UdpateDVD(DVD dvd)
        {
            var rowsAffected = 0;
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.Add("@Title", SqlDbType.VarChar, 50).Value = dvd.Title;
                    cmd.Parameters.Add("@Genre", SqlDbType.VarChar, 50).Value = dvd.Genre;
                    cmd.Parameters.Add("@QuantityInStock", SqlDbType.VarChar, 50).Value = dvd.QuantityInStock;
                    cmd.Parameters.Add("@SalesPrice", SqlDbType.VarChar, 50).Value = dvd.SalesPrice;
                    cmd.Parameters.Add("@PurchasePrice", SqlDbType.VarChar, 50).Value = dvd.PurchasePrice;

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        private static void AssignColumnValues(SqlDataReader rdr, DVD item)
        {
            item.DVD_ID = (!rdr.IsDBNull(0)) ? rdr.GetInt32(0) : 0;
            item.Title = (!rdr.IsDBNull(1)) ? rdr.GetString(1) : String.Empty;
            item.Genre = (!rdr.IsDBNull(2)) ? (MovieGenre)rdr.GetInt32(2) : 0;
            item.QuantityInStock = (!rdr.IsDBNull(3)) ? rdr.GetInt32(3) : 0;
            item.SalesPrice = (!rdr.IsDBNull(4)) ? rdr.GetDecimal(4) : 0.0M;
            item.PurchasePrice = (!rdr.IsDBNull(5)) ? rdr.GetDecimal(5) : 0.0M;
        }

        public bool VerifDVDExists(int dvd_ID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_VERIFY_EXISTS, conn))
                {
                    cmd.Parameters.Add("@DVD_ID", SqlDbType.Int).Value = dvd_ID;

                    conn.Open();
                    var id = cmd.ExecuteScalar();
                    return Convert.ToInt32(id) == 1;
                }
            }
        }
    }
}
