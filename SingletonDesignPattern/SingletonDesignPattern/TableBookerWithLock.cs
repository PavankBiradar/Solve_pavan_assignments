using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class TableBookerWithLock
    {
        public string BookingType { get; set; }

        public string TableNumber { get; set; }

        public int BookingTime { get; set; }
        private static TableBookerWithLock? instance = null;
        private static readonly object obj = new object();
        
        private TableBookerWithLock() { }//parameterless private constructor
        private TableBookerWithLock(string bookingType, string tableNumber)
        {
            BookingType = bookingType;
            TableNumber = tableNumber;
        }

        private TableBookerWithLock(string bookingType, string tableNumber, int bookingTime)
        {
            BookingType = bookingType;
            TableNumber = tableNumber;
            BookingTime = bookingTime;
        }

        
        public static TableBookerWithLock GetInstance
        {
            get
            {
                lock (obj) 
                {
                   if (instance == null)
                   {
                       instance = new TableBookerWithLock();
                   }
                    return instance;

                }
                   
            }
        }
    }
}

