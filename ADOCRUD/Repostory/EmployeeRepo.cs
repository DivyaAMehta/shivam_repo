using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System;
using ADOCRUD.Models;
using System.Data.SqlClient;

namespace ADOCRUD.Repostory
{
    public class EmployeeRepo
    {
        private readonly string _connectionString;
        public IConfiguration Configuration { get; }

        public EmployeeRepo(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:Employeeconn"];
        }
        public IEnumerable<Employees> Get()
        {
            var employees = new List<Employees>();
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = "Select * from Employee";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var employee = new Employees()
                {
                    EmpId = Convert.ToInt32(dataTable.Rows[i]["EmpId"]),
                    EmpName = dataTable.Rows[i]["EmpName"].ToString(),
                    Job = dataTable.Rows[i]["Job"].ToString(),
                    Salary = Convert.ToDecimal(dataTable.Rows[i]["Salary"]),
                };
                employees.Add(employee);
            }
            return employees;
        }

        public bool Create(Employees employees)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Insert into Employee (EmpName, Job, Salary) Values ('{employees.EmpName}', " +
                             $"'{employees.Job}', '{employees.Salary}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
        }

        public bool Update(Employees employees, int EmpId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Update Employee SET EmpName='{employees.EmpName}', Job='{employees.Job}', Salary='{employees.Salary}' Where EmpId='{EmpId}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return true;
            }
        }

        public bool Delete(int EmpId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = $"Delete From Employee Where EmpId='{EmpId}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return true;
            }
        }
    }
}
