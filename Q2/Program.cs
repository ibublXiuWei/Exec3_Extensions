using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string result = "0123456789";
			string left1 = result.Left(5);
			Console.WriteLine(left1);
			
			result = "1";
			string Left2=result.Left(0);
			string Left3=result.Left(5);
			
			result = "";
			string Left4=result.Left(1);
			
			Console.WriteLine(Left4);
			Console.WriteLine(Left2);
			Console.WriteLine(Left3);
		}
	}
	public  static class Substring
	{
		public static string Left(this string source,int Length)
		{
			if(string.IsNullOrEmpty(source)) return string.Empty;
			if(Length<=0) return string.Empty;
			if(source.Length<Length) return source;
			return source.Substring(0, Length);
		}
	}
}
