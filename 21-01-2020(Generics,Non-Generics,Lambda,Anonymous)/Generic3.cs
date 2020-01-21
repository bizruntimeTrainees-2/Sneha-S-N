using System;

namespace Generics
{
	public class Calculator
	{
          public static bool AreEqual(Object Value1, Object Value2)
		    {
			  return Value1 == Value2;
		    }
	}

	class Generic3
	{
		private static void Main(string[] args)
		{
			bool Equal = Calculator.AreEqual("A","A");

			if(Equal)
			{
                Console.WriteLine("Equal");
			}
			else
			{
				Console.WriteLine("Not Equal");
			}
		}
	}
}