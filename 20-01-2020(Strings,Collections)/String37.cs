using System;
using System.Text;

public class String37
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#, How Are ***?";
		string s2 = s1.Replace("***","You");

		Console.Write(s2);
	}
}