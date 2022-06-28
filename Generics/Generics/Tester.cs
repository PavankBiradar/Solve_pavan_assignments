using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Tester {

        public static void Main() {
            Console.WriteLine("Enter the String input:");
            String input = Console.ReadLine();
            Console.WriteLine("Enter the choice 1 to convert a string into int and 2 to convert into String:");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Converter<int>.Convert(input);
                    break;
                case 2:
                    Converter<DateTime>.ConvertToDate(input);
                    break;
                default:
                    Console.WriteLine("invalid Choice");
                    break;
            }
            
            
            
        }
    
    }
}
