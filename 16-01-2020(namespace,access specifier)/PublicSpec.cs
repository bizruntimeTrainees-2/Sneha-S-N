using System;

namespace AccessSpecifiers
{
	class PublicTest
	{
		public string name = "Shweta SN";
		public void Msg(string msg)
		{
			Console.WriteLine("Hello " + msg);
		}
	}

    public class PublicSpec
	{
		static void Main(string[] args)
		{
			PublicTest publicTest = new PublicTest();
			Console.WriteLine("Hello " + publicTest.name);
			publicTest.Msg("Sneha SN");
		}
	}
}