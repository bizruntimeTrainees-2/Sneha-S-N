using System;
public class String5
{
	public static void Main(string[] args)
	{
		string s1 = "hello";
		string s2 = "hello";
		string s3 = "csharp";

		Console.WriteLine(s1.CompareTo(s2));
		Console.WriteLine(s2.CompareTo(s3));
	}
}