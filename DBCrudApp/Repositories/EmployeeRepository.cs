using DBCrudApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBCrudApp.Entities;
using Microsoft.Extensions.Configuration;

namespace DBCrudApp.Repositories
{
    public class EmployeeRepository : BaseRepository
    {
        public EmployeeRepository(IConfiguration config) : base(config)
        {
            
        }
        public List<Employee> GetData()
        {
            string commandString = "Select * FROM Employees;";

            var connection = new SqlConnection(_connectionString);
            var command = new SqlCommand(commandString, connection);

            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            var employees = new List<Employee>();

            foreach (DataRow row in dataTable.Rows)
            {
                var employee = new Employee()
                {
                    EmployeeID = (int)row["EmployeeID"],
                    LastName = (string)row["LastName"],
                    FirstName = (string)row["FirstName"],
                    Title = row["Title"]?.ToString(),
                    TitleOfCourtesy = row["TitleOfCourtesy"]?.ToString(),
                    BirthDate = (row["BirthDate"] as DateTime?),

                    HireDate = (row["HireDate"] as DateTime?),
                    Address=row["Address"]?.ToString(),
                    City=row["City"]?.ToString(),
                    Region=row["Region"]?.ToString(),
                    PostalCode=row["PostalCode"]?.ToString(),
                    Country=row["Country"]?.ToString(),
                    HomePhone=row["HomePhone"]?.ToString(),
                    Extension=row["Extension"]?.ToString(),
                    ReportsTo=(row["ReportsTo"] as int?),
                    PhotoPath=row["PhotoPath"]?.ToString(),

                };

                employees.Add(employee);
            }

            return employees;
        }

    }
}
