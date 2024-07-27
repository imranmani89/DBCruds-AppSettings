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
    public class CategoryRepository: BaseRepository
    {

        public CategoryRepository(IConfiguration config) : base(config)
        {

        }


        public List<Category> GetData()
        {
            string commandString = "Select * FROM Northwind.dbo.Categories;";

            var connection = new SqlConnection(_connectionString);
            var command = new SqlCommand(commandString, connection);

            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            var cat = new List<Category>();

            foreach (DataRow row in dataTable.Rows)
            {
                var cate = new Category()
                {
                    CategoryID = (int)row["CategoryID"],
                    CategoryName = (string)row["CategoryName"],
                    Description = row["Description"]?.ToString(),

                };

                cat.Add(cate);
            }

            return cat;
        }

    }
}