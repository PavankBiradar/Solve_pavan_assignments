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
        public static DateTime ConvertToDate(string input)
        {

            DateTime response = DateTime.Parse(input);
            Console.WriteLine(response);
            return response;
        }
    }
    




}