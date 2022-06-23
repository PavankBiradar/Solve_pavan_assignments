using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class HotelTable
    {
        public string TableNumber { get; set; }
        public int  BookingTime { get; set; }
        public int ReservedTime { get; set; }

        private HotelTable() {
            //In Parameterless constructor;
        }

        private static HotelTable  instance=null;
        public static HotelTable GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new HotelTable();

                return instance;
            }
        }
    }
}
