using System;
public class String21
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#";
		string s2 = string.Intern(s1);
		string s3 = string.IsInterned(s1);

		Console.WriteLine(s1);
		Console.WriteLine(s2);
		Console.WriteLine(s3);
	}
}