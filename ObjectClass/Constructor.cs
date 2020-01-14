using System;
namespace Constructor
{
public class Constructor
{
	public Constructor()
	{
	    Console.WriteLine("Default Constructor invoked");
	}
	//Having Main() within class
	public static void Main(string[] args)
	{
		Constructor e1 = new Constructor();
		Constructor e2 = new Constructor();
	}
}
}
