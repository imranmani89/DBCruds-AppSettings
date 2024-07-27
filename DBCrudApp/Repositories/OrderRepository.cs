using DBCrudApp.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCrudApp.Repositories
{
    public  class OrderRepository : BaseRepository
    {

        public OrderRepository(IConfiguration config) : base(config)
        {

        }
        public  List<Order>GetData()
     {
            string CommandString = "select * from Orders";
        var sqlConnection = new SqlConnection(_connectionString);
        var command = new SqlCommand(CommandString, sqlConnection);
            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            
            var Orders=new List<Order>();
            foreach (DataRow row in dataTable.Rows)
            {
                var Ord = new Order() {
                    OrderID = (int)row["OrderID"],
                    CustomerID = row["CustomerID"]?.ToString(),
                   EmployeeID =row["EmployeeID"]as int?,
                    OrderDate = row["OrderDate"] as DateTime?,
                    RequiredDate = row["RequiredDate"]as DateTime?,
                    ShippedDate = row["ShippedDate"]as DateTime?,
                    ShipVia = row["ShipVia"]as int?,
                    Freight = row["Freight"]as decimal?,
                    ShipName =row["ShipName"]?.ToString(),
                    ShipAddress=row["ShipAddress"]?.ToString(),
                    ShipCity=row["ShipCity"]?.ToString(),
                    ShipRegion=row["ShipRegion"]?.ToString(),
                    ShipPostalCode=row["ShipPostalCode"]?.ToString(),
                    ShipCountry=row["ShipCountry"]?.ToString(),
                };
                Orders.Add(Ord);
            }
            return Orders;
        }
            
    }
}

