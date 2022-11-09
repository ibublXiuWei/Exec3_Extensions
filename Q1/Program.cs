using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool IsEven = 99.IsEven();
			Console.WriteLine(IsEven);
			bool IsOdd=99.IsOdd();
			Console.WriteLine(IsOdd);
		}
	}

	public static class MyMath
	{
		public static bool IsEven(this int n1)
		{
			return  n1 % 2 == 0;
		}
		public static bool IsOdd(this int n)
		{
			return n % 2 == 1;
		}
	}
}
