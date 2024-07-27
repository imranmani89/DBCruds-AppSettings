using DBCrudApp.Entities;
using DBCrudApp.Models;
using DBCrudApp.Repositories;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace DBCrudApp;


public static class Program
{
    public static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration config = builder.Build();

        string answer;
        do
        {
            Console.WriteLine(new BaseRepository(config).GetStringData());
            Console.WriteLine("Select from the options below\n1.EmployeeTable\n2.CategoryTable\n3.CustomerTable\n4.EmployeeTerritoryTable\n5.OrderDetailTable\n6.OrderTable\n7.ProductTable\n8.RegionTable\n9.ShipperTable\n10.TerritoryTable\n11.SupplierTable");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {

                case 1:
                    var list = new EmployeeRepository(config).GetData();
                    foreach (var item in list)
                    {
                        Console.WriteLine($"{item.EmployeeID}\t {item.FirstName} {item.LastName}\t {item.Title}\t {item.TitleOfCourtesy}\t {item.BirthDate}\t {item.HireDate}\t {item.Address}\t {item.City}\t {item.Region}\t {item.PostalCode}\t  {item.Country}\t {item.HomePhone}\t {item.Extension}\t {item.ReportsTo}\t  {item.PhotoPath}");
                    }
                    break;
                case 2:
                    var list1 = new CategoryRepository(config).GetData();
                    foreach (var item in list1)
                    {

                        Console.WriteLine($"{item.CategoryID}\t{item.CategoryName}\t{item.Description}");
                    }
                    break;
                case 3:
                    var list2 = new CustomerRepository(config).GetData();
                    foreach (var item in list2)
                    {

                        Console.WriteLine($"{item.CustomerID}\t{item.CompanyName}\t{item.ContactName}\t{item.ContactTitle}\t{item.Address}\t{item.City}\t{item.Region}\t{item.PostalCode}\t{item.Country}\t{item.Phone}\t{item.Fax}");
                    }
                    break;
                case 4:

                    var list3 = new EmployeeTerritoryRepository(config).GetData();
                    foreach (var item in list3)
                    {
                        Console.WriteLine($"{item.EmployeeID}\t{item.TerritoryID}");
                    }
                    break;
                case 5:
                    var list4 = new OrderDetailRepository(config).GetData();
                    foreach (var item in list4)
                    {
                        Console.WriteLine($"{item.OrderID}\t{item.ProductID}\t{item.UnitPrice}\t{item.Quantity}\t{item.Discount}");
                    }
                    break;
                case 6:
                    var list5 = new OrderRepository(config).GetData();
                    foreach (var item in list5)
                    {
                        Console.WriteLine($"{item.OrderID}\t\t{item.CustomerID}\t\t{item.EmployeeID}\t\t{item.OrderDate}t\t{item.RequiredDate}t\t{item.ShippedDate}\t\t{item.ShipVia}\t\t{item.Freight}\t\t{item.ShipName}\t\t{item.ShipAddress}\t\t{item.ShipCity}\t\t{item.ShipRegion}\t\t{item.ShipPostalCode}\t\t{item.ShipCountry}");
                    }
                    break;
                case 7:
                    var list6 = new ProductRepository(config).GetData();
                    foreach (var item in list6)
                    {
                        Console.WriteLine($"{item.ProductID}\t\t{item.ProductName}\t\t{item.SupplierID}\t\t{item.CategoryID}t\t{item.QuantityPerUnit}t\t{item.UnitPrice}\t\t{item.UnitsInStock}\t\t{item.UnitsOnOrder}\t\t{item.ReorderLevel}\t\t{item.Discontinued}");
                    }
                    break; 
                case 8:
                    var list7 = new RegionRepository(config).GetData();
                    foreach (var item in list7)
                    {
                        Console.WriteLine($"{item.RegionID}\t\t{item.RegionDescription}");
                    }
                    break;
                case 9:
                    var list8 = new ShipperRepository(config).GetData();
                    foreach (var item in list8)
                    {
                        Console.WriteLine($"{item.ShipperID}\t\t{item.CompanyName}\t\t{item.Phone}");
                    }
                    break;
                case 10:
                    var list9 = new TerritoryRepository(config).GetData();
                    foreach (var item in list9)
                    {
                        Console.WriteLine($"{item.RegionID}\t\t{item.TerritoryID}\t\t{item.TerritoryDescription}");
                    }
                    break;
                case 11:
                    var list10 = new SupplierRepository(config).GetData();
                    foreach (var item in list10)
                    {
                        Console.WriteLine($"{item.SupplierID}\t\t{item.CompanyName}\t\t{item.ContactTitle}\t\t{item.Address}\t\t{item.City}\t\t{item.Region}\t\t{item.PostalCode}\t\t{item.Fax}\t\t{item.Country}\t\t{item.Phone}\t\t{item.HomePage}");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Wrong Input");
                    }
                    break;
            }
            Console.WriteLine("Do you want to continue? YES / NO");
            answer = Console.ReadLine().ToUpper();
        }
            while (answer != "NO");
        }

    }
