using System;
using System.Text;

public class String49
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#";
		char[] ch = {'H'};

		string s2 = s1.TrimStart(ch);
	    Console.WriteLine(s2);
	}
}