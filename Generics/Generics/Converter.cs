using System;
namespace Generics
{

        public class Converter
        {
        public static void ConvertTo<T>(string input) {

            if (typeof(T) == typeof(int)) {
                int response = Int32.Parse(input);
                Console.WriteLine(response);
            }
            else if (typeof(T) == typeof(DateTime)) {
                DateTime response = DateTime.Parse(input);
                Console.WriteLine(response);
            } 
           
            }
            
         }
       
    }
    




