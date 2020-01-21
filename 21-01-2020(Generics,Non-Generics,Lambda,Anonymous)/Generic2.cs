using System;

namespace Generics
{
	class GenericClass
	{
          public void Method<T>(T msg)
		    {
			  Console.WriteLine(msg);
		    }
	}

	class Generic2
	{
		public static void Main(string[] args)
		{
			GenericClass gen = new GenericClass();
		    gen.Method("This is Generic Class");
			gen.Method(32);
			gen.Method('S');
		}
	}
}