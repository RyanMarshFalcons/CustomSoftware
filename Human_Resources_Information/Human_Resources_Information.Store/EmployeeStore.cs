using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human_Resources_Information.Data;

namespace Human_Resources_Information.Store
{
    public class EmployeeStore
    {
        private const string SQL_VERIFY_EXISTS =
            "SELECT COUNT(1) "
            + "FROM [dbo].[Employee] "
            + "WHERE EmployeeID = @EmployeeID ";

        private const string SQL_SELECT =
            "SELECT EmployeeID, FirstName, LastName, Department, JobTitle, HireDate, "
        + "Address, Salary, EmployeeRatingScore "
        + "FROM [dbo].[Employee] "
        + "WHERE IsDeleted = 0 ";


        private const string SQL_SELECT_ROW =
            SQL_SELECT + "AND EmployeeID = @EmployeeID ";

        private const string SQL_DELETE =
               "UPDATE [dbo].[Employee] "
               + "SET IsDeleted = 1 "
               + "WHERE EmployeeId = @EmployeeId ";

        private const string SQL_INSERT = "INSERT INTO [dbo].[Employee] "
            + "([FirstName],[LastName],[Department],[JobTitle],[HireDate],[Address],[Salary]) "
            + "VALUES "
            + "(@FirstName, @LastName, @Department, @JobTitle, @HireDate, @Address, @Salary); "
            + "SELECT @@IDENTITY ";

        private const string SQL_UPDATE_EmployeeReview =
                "UPDATE [dbo].[Employee] "
                + "SET EmployeeRatingScore = @EmployeeRatingScore "
                + "WHERE EmployeeID = @EmployeeID ";

        public int AddEmployee(Employee employee)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_INSERT, conn))
                {
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = employee.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = employee.LastName;
                    cmd.Parameters.Add("@Department", SqlDbType.Int, 50).Value = (int)employee.Department;
                    cmd.Parameters.Add("@JobTitle", SqlDbType.VarChar, 50).Value = employee.JobTitle;
                    cmd.Parameters.Add("@HireDate", SqlDbType.DateTime, 50).Value = employee.HireDate;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar, 50).Value = employee.Address;
                    cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = employee.Salary;

                    conn.Open();
                    var id = cmd.ExecuteScalar();
                    return Convert.ToInt32(id);
                }
            }
        }

        public bool VerifyEmployeeExists(int employeeID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_VERIFY_EXISTS, conn))
                {
                    cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeID;

                    conn.Open();
                    var id = cmd.ExecuteScalar();
                    return Convert.ToInt32(id) == 1;
                }
            }
        }

        public object DeleteEmployee(int employeeID)
        {
            var rowsAffected = 0;
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_DELETE, conn))
                {
                    cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeID;
                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public Employee GetEmployee(int employeeID)
        {
            var employee = new Employee();
            using (var conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(SQL_SELECT_ROW, conn);
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeID;

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    AssignColumnValues(rdr, employee);
                }
            }
            return employee;
        }

        public void UpdateEmployeeReview(Employee employee)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(SQL_UPDATE_EmployeeReview, conn))
                {
                    cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employee.EmployeeID;
                    cmd.Parameters.Add("@EmployeeRatingScore", SqlDbType.Int, 50).Value = employee.EmployeeRatingScore;
                    
                    conn.Open();
                }
            }
        }

        private static void AssignColumnValues(SqlDataReader rdr, Employee item)
        {
            item.EmployeeID = (!rdr.IsDBNull(0)) ? rdr.GetInt32(0) : 0;
            item.FirstName = (!rdr.IsDBNull(1)) ? rdr.GetString(1) : String.Empty;
            item.LastName = (!rdr.IsDBNull(2)) ? rdr.GetString(2) : String.Empty;
            item.Department = (!rdr.IsDBNull(3)) ? (Department)rdr.GetInt32(3) : 0;
            item.JobTitle = (!rdr.IsDBNull(4)) ? rdr.GetString(4) : String.Empty;
            item.HireDate = (!rdr.IsDBNull(5)) ? rdr.GetDateTime(5) : DateTime.MinValue;
            item.Address = (!rdr.IsDBNull(6)) ? rdr.GetString(6) : String.Empty;
            item.Salary = (!rdr.IsDBNull(7)) ? rdr.GetDecimal(7) : 0M;
            item.EmployeeRatingScore = (!rdr.IsDBNull(8)) ? rdr.GetInt32(8) : 0;
        }
    }
}
