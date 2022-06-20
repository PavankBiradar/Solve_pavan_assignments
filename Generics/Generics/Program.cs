using System;
namespace Generics
{

    class TConverter<T>
    {
        //convert String to number and string to date
        public T str { get; set; }
        public T str1 { get; set; }
    }
    internal class TesterClass
    {
        public static void Main(string[] args)
        {
            //String to Int Conversion
            TConverter<string> obj1 = new TConverter<string>();
            obj1.str = "20011998";
            int num = int.Parse(obj1.str);
            Console.WriteLine(num);
            //String to Date Conversion
            TConverter<string> obj = new TConverter<string>();
            obj.str1 = "Mon Jun 20, 2022 ";
            DateTime dt = DateTime.Parse(obj.str1);
            Console.WriteLine(dt);

        }
    }




}