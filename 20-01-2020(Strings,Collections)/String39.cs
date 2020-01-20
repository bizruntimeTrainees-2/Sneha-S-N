using System;
using System.Text;

public class String39
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#, how Are You?";
		bool b1 = s1.StartsWith("h");
		bool b2 = s1.StartsWith("H");

	    Console.Write(b1);
	    Console.Write(b2);
		
	}
}