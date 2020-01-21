using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions 
{
	class Example1
	{
		public static void Main(string[] args)
		{
			List<int> numbers = new List<int>() {36, 71, 12, 15, 29, 18, 27, 17, 9, 34};

			Console.Write("The list : ");

			foreach(var value in numbers)
			{
				Console.Write("{0}", value);
			}
			Console.WriteLine();

			var square = numbers.Select(x => x * x);

			Console.Write("Square : ");
			foreach(var value in square)
			{
				Console.WriteLine("{0}", value);
			}
			Console.WriteLine();
 
            List<int> divBy3 = numbers.FinaAll(x => (x % 3) == 0);

			Console.WriteLine("Numbers Divisible by 3 : ");

			foreach(var value in divBy3)
			{
				Console.Write("{0}", value);
			}
			Console.WriteLine();

		}
	}
}