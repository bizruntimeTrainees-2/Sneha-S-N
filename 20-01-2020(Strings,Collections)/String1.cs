using System;
public class String1
{
	public static void Main(string[] args)
	{
		string s1 = "hello";

		char[] ch = {'a','b','c','d','e'};
		string s2 = new string(ch);

		Console.WriteLine(s1);
		Console.WriteLine(s2);
	}
}