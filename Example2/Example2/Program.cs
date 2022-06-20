using System;
namespace Example2{
    class User {
        private string location="";
        private string name="";
        private int? age;
        public string Location {
        get { return location; }set { location = value; } 
         }
        public string Name {
        get { return name; } set { name = value; } 
        }
        public int Age { 
        get { return (int)age; } set {if(age>0) age = value; }
        }
    }
    class tester
    {
        public static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Pavan Biradar";
            user.Location = "Latur";
            user.Age = 24;
            Console.WriteLine("User Name :" + user.Name);
            Console.WriteLine("User Location :" + user.Location);
            Console.WriteLine("User Age :" +user.Age);
            Console.ReadLine();

        }
    }

}
