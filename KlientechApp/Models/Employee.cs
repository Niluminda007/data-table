using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KlientechApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Telephone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Action { get; set; }
        public int Age { get; set; }

    }
}