//params using Array
using System;
namespace Command
{
class CommandLineArg
{
	public static void Main(string[] args)
	{
	     Console.WriteLine("Argument length: " +args.Length);
	     Console.WriteLine("Supplied Argument are:");
		 foreach(Object obj in args)
		{
			 Console.WriteLine(obj);
		}
	}
}
}
