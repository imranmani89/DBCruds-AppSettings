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
    public  class ShipperRepository : BaseRepository
    {
        public ShipperRepository(IConfiguration config) : base(config)
        {

        }
        public  List<Shipper> GetData()
        {
            string commandString = "Select * FROM Northwind.dbo.Shippers";

            var connection = new SqlConnection(_connectionString);
            var command = new SqlCommand(commandString, connection);
            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            var ship = new List<Shipper>();

            foreach (DataRow row in dataTable.Rows)
            {
                var ships = new Shipper()
                {
                    ShipperID = (int)row["ShipperID"],
                    CompanyName = (string)row["CompanyName"],
                    Phone = row["Phone"]?.ToString(),

                };

                ship.Add(ships);
            }

            return ship;
        }

    }
}
