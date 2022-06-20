using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_extension
{
    public static class ChangeFirstLetterCase
    {
        //Method to Change the First letter to upper case
        public static string ChangeFirstLetterToUpperCase(this string input)
        {
            string result = char.ToUpper(input[0]) + input.Substring(1);
            return result;
        }
        //Method to Change the First Letter To Lower Case
        public static string ChangeFirstLetterToLowerCase(this string input)
        {
            string result = char.ToLower(input[0]) + input.Substring(1);
            return result;
        }
    }


}
