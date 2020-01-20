using System;
using System.Text;

public class String48
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#";
		char[] ch = {'#'};

		string s2 = s1.TrimEnd(ch);
	    Console.WriteLine(s2);
	}
}