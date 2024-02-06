using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetXmlApp
{
    public class Employee
    {
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Position { get; set; }
        public decimal Salary { get; set; }

        public Employee() {}

        public Employee(string? name, 
            DateTime birthDate, 
            string? position, 
            decimal salary)
        {
            Name = name;
            BirthDate = birthDate;
            Position = position;
            Salary = salary;
        }
    }
}
