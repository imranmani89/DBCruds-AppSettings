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
    public  class RegionRepository : BaseRepository
    {
        public RegionRepository(IConfiguration config) : base(config)
        {

        }
        public  List<Region> GetData()
        {
            string commandString = "Select * FROM Northwind.dbo.Region";

            var connection = new SqlConnection(_connectionString);
            var command = new SqlCommand(commandString, connection);

            var dataAdapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            var Reg = new List<Region>();

            foreach (DataRow row in dataTable.Rows)
            {
                var Regs = new Region()
                {
                    RegionID = (int)row["RegionID"],
                    RegionDescription = (string)row["RegionDescription"],   

                };

                Reg.Add(Regs);
            }

            return Reg;
        }

    }
}
