using System;
using System.Text;

public class String25
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#";
		string s2 = "";

		bool b1 = string.IsNullOrEmpty(s1);
		bool b2 = string.IsNullOrEmpty(s2);

		Console.WriteLine(b1);
		Console.WriteLine(b2);
	}
}