using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //Assignment: LINQ
    //1. Create an employee class with properties (Id, Name, City, Salary).
    //2. Create List of Employees with hardcodes employes(100 entries, Id 1 to 100)
    //3. Write a Linq query to find employee with an id 45
    //4. Write a Linq query to find employees with an id that are even
    //5. Write a Linq query to find highest salary holder
    //6. Write a Linq query to find highest salary holder in Pune City
    //7. Write a Linq query to find highest salary holder from each city


    class Program
    {
        static void Main(string[] args)
        {
            //list of employee type
            List<Employee> empList = new List<Employee>();

            var cityList = new List<String> { "Pune", "Latur", "Solapur", "Nagar", "Nagpur", "Usmanabad", "Jalgaon", "Nashik" };
            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                int index = random.Next(cityList.Count);
                empList.Add(new Employee()
                {
                    EmpId = i,
                    EmpName = "Pavan_" + i,
                    City = cityList[index],
                    Salary = 60000 + i



                }); ;
            }
           ;


            //for loop to print the employee details
            /* for (int i = 0; i <= empList.Count-1; i++)
             {
                 Console.WriteLine("EmpId of employee {0} Name is {1} and Employee City is {2}", empList[i].EmpId, empList[i].EmpName, empList[i].City);
             }*/


            //3. Write a Linq query to find employee with an id 45--------------------------------
            Console.WriteLine("1.Employee details with id=45 :");
            var result1 = empList.Where(e => e.EmpId == 45);

            foreach (var e in result1)
            {
                Console.WriteLine(e.EmpName + "--" + e.City);
            }

            //4. Write a Linq query to find employees with an id that are even-------------------------------------------
            Console.WriteLine("2.Details of employees having even id :");
            var result2 = empList.Where(e => e.EmpId % 2 == 0);

            foreach (var e in result2)
            {
                Console.WriteLine(e.EmpName + "--" + e.City);
            }
            //5. Write a Linq query to find highest salary holder---------------------------------------------------------

            var result3 = empList.Max(e => e.Salary);

            Console.WriteLine("3.Maximum Salary of the Employee : {0}", result3);


            //6. Write a Linq query to find highest salary holder in Pune City---------------------------------------------


            var highSalaryCity = empList.Where(emp => emp.City == "Pune").GroupBy(e => e.City)
              .Select(em => em.OrderByDescending(e => e.Salary).First());
            Console.WriteLine("4.Max Salary in Pune :");
            foreach (Employee emp in highSalaryCity)
            {
                Console.WriteLine("ID:" + emp.EmpId + " Name:" + emp.EmpName + " City:" + emp.City + " Salary:" + emp.Salary);
            }


            //7. Write a Linq query to find highest salary holder from each city------------------------------------------
            Console.WriteLine("5.Employee details having max sal in each respective city :");
            var highSalEachCity = empList.GroupBy(e => e.City)
             .Select(em => em.OrderByDescending(e => e.Salary).First());
            foreach (Employee emp in highSalEachCity)
            {
                Console.WriteLine("ID:" + emp.EmpId + " Name:" + emp.EmpName + " City:" + emp.City + " Salary:" + emp.Salary);
            }
        }
        class Employee
        {
            public int EmpId { get; set; }
            public string? EmpName { get; set; }
            public string? City { get; set; }
            public int Salary { get; set; }
        }


    }
}
