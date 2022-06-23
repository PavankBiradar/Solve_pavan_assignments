using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal class TableBooker
    {
        static void Main(string[] args)
        {
           
            HotelTable book = HotelTable.GetInstance;
            book.TableNumber = "A-05";
            book.BookingTime = 7;
            book.ReservedTime = 1;

            Console.WriteLine(" " + book.TableNumber + "  " + book.BookingTime + "   " + book.ReservedTime);

            HotelTableWithLock booker = HotelTableWithLock.GetInstance;
            booker.TableNumber = "A-06";
            booker.BookingTime = 8;
            booker.ReservedTime = 1;

           
            Console.WriteLine(" " + booker.TableNumber + "  " + booker.BookingTime + "   " + booker.ReservedTime);

           


        }
    }
}
