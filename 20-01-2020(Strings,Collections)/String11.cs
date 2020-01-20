using System;
public class String11
{
	public static void Main(string[] args)
	{
		string s1 = "Hello";
		string s2 = "llo";
		string s3 = "C#";

		Console.WriteLine(s1.EndsWith(s2));
		Console.WriteLine(s1.EndsWith(s3));
	}
}