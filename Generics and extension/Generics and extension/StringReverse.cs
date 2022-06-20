using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_and_extension
{
	public static class StringReverse
	{
		//Method to reverse the whole String
		public static string Reverse(this string input)
		{
			char[] arr = input.ToCharArray();
			Array.Reverse(arr);

			string result = new String(arr);
			return result;
		}


	}

}
