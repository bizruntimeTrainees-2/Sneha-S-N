using System;
public class String20
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#";
		string s2 = string.Intern(s1);

		Console.WriteLine(s1);
		Console.WriteLine(s2);
	}
}