using System;
using System.Text;

public class String26
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#";
		string s2 = "";
		string s3 = " ";

		bool b1 = string.IsNullOrWhiteSpace(s1);
		bool b2 = string.IsNullOrWhiteSpace(s2);
		bool b3 = string.IsNullOrWhiteSpace(s3);

		Console.WriteLine(b1);
		Console.WriteLine(b2);
		Console.WriteLine(b3);
	}
}