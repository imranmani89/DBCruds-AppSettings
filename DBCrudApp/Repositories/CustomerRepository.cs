﻿using DBCrudApp.Models;
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
    public class CustomerRepository : BaseRepository
    {
        public CustomerRepository(IConfiguration config): base(config)
        {
            
        }


        public List<Customer> GetData()
        {
            string commandString = "Select * FROM Northwind.dbo.Customers;";

            var connection = new SqlConnection(_connectionString);
            var command = new SqlCommand(commandString, connection);

            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            var custs = new List<Customer>();

            foreach (DataRow row in dataTable.Rows)
            {
                var cust = new Customer()
                {
                    CustomerID = (string)row["CustomerID"],
                    CompanyName = (string)row["CompanyName"],
                    ContactName = row["ContactName"]?.ToString(),
                    ContactTitle = row["ContactTitle"]?.ToString(),
                    Address = row["Address"]?.ToString(),
                    City = row["City"]?.ToString(),
                    Region = row["Region"]?.ToString(),
                    PostalCode = row["PostalCode"]?.ToString(),
                    Country = row["Country"]?.ToString(),
                    Phone = row["Phone"]?.ToString(),
                    Fax = row["Fax"]?.ToString(),
                };


                custs.Add(cust);
            }

            return custs;
        }

    }
}