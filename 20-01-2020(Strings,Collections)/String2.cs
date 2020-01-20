using System;
public class String2
{
	public static void Main(string[] args)
	{
		string s1 = "hello";
		string s2 = (String)s1.Clone();

		Console.WriteLine(s1);
		Console.WriteLine(s2);
	}
}