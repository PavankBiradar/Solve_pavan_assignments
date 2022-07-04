using System;
using System.Collections.Generic;

namespace RestAPIExample.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }

        public Decimal Salary { get; set; }
        public string City { get; set; }

       

        internal static List<Employee> SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
