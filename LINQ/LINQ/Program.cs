using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program    {
        static void Main(string[] args)
        {
           
            var empList = new List<Employee>();

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

          
            Console.WriteLine("1.Employee details with id=45 :");
            var emp45 = empList.First(e => e.EmpId == 45);
            Console.WriteLine($"ID:{emp45.EmpId} Name: {emp45.EmpName}  City:{emp45.City} Salary: {emp45.Salary} ");
            

            Console.WriteLine("2.Details of employees having even id :");
            foreach (var e in empList.Where(e => e.EmpId % 2 == 0))
            {
                Console.WriteLine(e.EmpName + "--" + e.City);
            }
            

            var MaxSal = empList.OrderByDescending(e => e.Salary).First();
            Console.WriteLine($"ID: {MaxSal.EmpId } Name:{MaxSal.EmpName} City:{MaxSal.City} Salary: {MaxSal.Salary}");


            Console.WriteLine("4.Max Salary in Pune :");
            var emp = empList.Where(emp => emp.City == "Pune").OrderByDescending(e => e.Salary).First();
            
                Console.WriteLine($"ID: {emp.EmpId } Name:{emp.EmpName} City:{emp.City} Salary: {emp.Salary}");
                
            

           
            Console.WriteLine("5.Employee details having max sal in each respective city :");

            foreach (var emp1 in empList.GroupBy(e => e.City)
             .Select(em => em.OrderByDescending(e => e.Salary).First()))
            {
                Console.WriteLine($"ID: {emp1.EmpId } Name:{emp1.EmpName} City:{emp1.City} Salary: {emp1.Salary}");
            }
        }
        


    }
}
