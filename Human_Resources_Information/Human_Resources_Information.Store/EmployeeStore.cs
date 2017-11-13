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

        private const string SQL_DELETE =
               "UPDATE [dbo].[Employee] "
               + "SET IsDeleted = 1 "
               + "WHERE EmployeeId = @EmployeeId ";

        private const string SQL_INSERT = "INSERT INTO [dbo].[Employee] "
            + "([FirstName],[LastName],[Department],[JobTitle],[HireDate],[Address],[Salary]) "
            + "VALUES "
            + "(@FirstName, @LastName, @Department, @JobTitle, @HireDate, @Address, @Salary); "
            + "SELECT @@IDENTITY ";

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
    }
}
