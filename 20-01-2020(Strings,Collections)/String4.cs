using System;
public class String4
{
	public static void Main(string[] args)
	{
		string s1 = "hello";
		string s2 = "hello";
		string s3 = "csharp";
		string s4 = "mello";

		Console.WriteLine(string.CompareOrdinal(s1,s2));
		Console.WriteLine(string.CompareOrdinal(s1,s3));
		Console.WriteLine(string.CompareOrdinal(s1,s4));
	}
}