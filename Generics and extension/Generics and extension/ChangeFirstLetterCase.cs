using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_extension
{
    public static class ChangeFirstLetterCase
    {
        //Method to Change the First letter Case
        public static String  Changecase(this string input)
        {
            String Output = "";
            if (char.ToLower(input[0]) == input[0])
            {
                Output = char.ToUpper(input[0]) + input.Substring(1);
            }
            else {
                Output = char.ToLower(input[0]) + input.Substring(1);
            }
            return Output;
        }
        
    }


}
