using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal class TesterClass
    {
        static void Main(string[] args)
        {
           
            TableBookerWithLock family = TableBookerWithLock.GetInstance;
            family.BookingType = "family-4";
            family.TableNumber = "F-05";
            family.BookingTime = 7;

            Console.WriteLine(" " + family.BookingType + "  " + family.TableNumber + "   " + family.BookingTime);

            TableBookerWithoutLock bachlor = TableBookerWithoutLock.GetInstance;
            bachlor.BookingType = "bachelors-6";
            bachlor.TableNumber = "B-03";
            bachlor.BookingTime = 6;


            Console.WriteLine(" " + bachlor.BookingType + "  " + bachlor.TableNumber + "   " + bachlor.BookingTime);

        }
    }
}
