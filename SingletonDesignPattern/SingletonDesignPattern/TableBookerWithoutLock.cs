using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class TableBookerWithoutLock
    {
        public string BookingType { get; set; }

        public string TableNumber { get; set; }

        public int BookingTime { get; set; }

        private TableBookerWithoutLock() { } //In Parameterless constructor;


        private TableBookerWithoutLock(string bookingType, string tableNumber)
        {
            BookingType = bookingType;
            TableNumber = tableNumber;
        }

        private TableBookerWithoutLock(string bookingType, string tableNumber, int bookingTime)
        {
            BookingType = bookingType;
            TableNumber = tableNumber;
            BookingTime = bookingTime;
        }

        private static TableBookerWithoutLock? instance=null;
        public static TableBookerWithoutLock GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new TableBookerWithoutLock();

                return instance;
            }
        }
    }
}
