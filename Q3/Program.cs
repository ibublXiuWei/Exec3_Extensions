using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string result = "123aaa";
			int num1 = result.ToInt(-1);
			Console.WriteLine(num1);
			result = "34";
			int num2=result.ToInt(-1);
			Console.WriteLine(num2);
		}
	}
	public static class Mymath
	{
		public static int ToInt(this string value,int defaultValue)
		{
			bool IsInt = int.TryParse(value, out int number);
			return (IsInt==true)? number: defaultValue;
		}
	}
}
