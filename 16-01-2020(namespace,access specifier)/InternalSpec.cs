using System;

namespace AccessSpecifiers
{
	class InternalTest
	{
		internal string name = "Sneha SN";

		internal void Msg(string msg)
		{
             Console.WriteLine("Hello " +msg);
		}
	}
		
    class InternalSpec
	{
		static void Main(string[] args)
		{
			InternalTest it = new InternalTest();
			Console.WriteLine("Hello " + it.name);
			it.Msg("Shweta SN");	
		}
	}
}