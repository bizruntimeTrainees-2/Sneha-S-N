using System;

namespace Generics
{
	class GenericClass<T>
	{
          public GenericClass(T msg)
		    {
			  Console.WriteLine(msg);
		    }
	}


	class Generic1
	{
		public static void Main(string[] args)
		{
			GenericClass<string> gen1 = new GenericClass<string>("This is Generic Class");
			GenericClass<int> gen2 = new GenericClass<int>(32);
			GenericClass<char> gen3 = new GenericClass<char>('S');
		}
	}
}