using System;
namespace Generics
{

        public class Converter<T>
        {
        public static int Convert(string input) {
           
            int response = Int32.Parse(input);
            Console.WriteLine(response);
            return response;
         }
        public static DateTime Converttodate(string input1)
        {

            DateTime response = DateTime.Parse(input1);
            Console.WriteLine(response);
            return response;
        }
    }
    




}