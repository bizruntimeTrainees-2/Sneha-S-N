using System;
using System.Text;

public class String32
{
	public static void Main(string[] args)
	{
		string s1 = "abcde";
		string s2 = s1.PadLeft(10);

		Console.WriteLine(s2);
	}
}