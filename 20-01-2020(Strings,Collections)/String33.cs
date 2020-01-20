using System;
using System.Text;

public class String33
{
	public static void Main(string[] args)
	{
		string s1 = "abcdede";
		string s2 = s1.PadRight(10);

		Console.Write(s2);
		Console.Write("fghi");
	}
}