using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Tester {

        public static void Main() {
            String input = "20011998";
            String input1 = "20 jan 2022";
            Converter<int>.Convert(input);
            Converter<DateTime>.ConvertToDate(input1);
            
        }
    
    }
}
