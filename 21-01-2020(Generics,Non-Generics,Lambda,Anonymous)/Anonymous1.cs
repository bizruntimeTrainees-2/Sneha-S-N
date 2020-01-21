using System;

namespace AnonymousMethods 
{
	class Anonymous1
	{
		public delegate void AnonymousFun();
		static void Main(string[] args)
		{
			Anonymous fun = delegate()
			{
			Console.WriteLine("This is anonymous function");
			};
			fun();
		}
	}
}

