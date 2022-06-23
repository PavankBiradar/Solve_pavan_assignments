using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class HotelTableWithLock
    {
        public string TableNumber { get; set; }
        public int BookingTime { get; set; }
        public int ReservedTime { get; set; }

        private static HotelTableWithLock  instance = null;
        private static readonly object obj = new object();
        
        private HotelTableWithLock() { }//parameterless private constructor
      
        public static HotelTableWithLock GetInstance
        {
            get
            {
                lock (obj) 
                {
                   if (instance == null)
                   {
                       instance = new HotelTableWithLock();
                   }
                    return instance;

                }
                   
            }
        }
    }
}

