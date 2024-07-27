using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCrudApp.Models
{
    public class Person
    {
        public int? Id { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String? Email { get; set; }
        public String? Address { get; set; }
        public String? CNIC { get; set; }
        public String? Phone { get; set; }
        public string? Designition { get; set; }
        public bool? isActive { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? RegistrationDate { get; set; } = DateTime.Now;
        public int? AddedBy { get; set; }


        public Person()
        {
            Console.WriteLine("Consutructor has been called.");
        }

        public Person(int? _id, string? _firstName, string? _lastName,
            string? _email, string? _address, string? _cNIC, 
            string? _phone, string? _designition,
            DateTime? _dOB, int? _addedBy)
            :this( _dOB,  _addedBy)
        {
            Id = _id;
            FirstName = _firstName;
            LastName = _lastName;
            Email = _email;
            Address = _address;
            CNIC = _cNIC;
            Phone = _phone;
            Designition = _designition;
        }

        public Person(DateTime? _DOB, int? _AddedBy)
        {
            isActive = true;
            DOB = _DOB;
            //RegistrationDate = DateTime.Now;
            
        }

        public string? DayOfDOB()
        {
            return DOB!.Value.DayOfWeek.ToString();
        }

    }
}
