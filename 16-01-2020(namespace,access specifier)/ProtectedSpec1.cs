using System;

namespace AccessSpecifiers
{
	class ProtectedTest
	{
		protected string name = "Sneha SN";

		protected void Msg(string msg)
		{
             Console.WriteLine("Hello " +msg);
		}
	}
		
    class ProtectedSpec1
	{
		static void Main(string[] args)
		{
			ProtectedTest pt = new ProtectedTest();
			Console.WriteLine("Hello " + pt.name);
			ps.Msg("Shweta");	
		}
	}
}