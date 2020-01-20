using System;
using System.Text;

public class String38
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#, How Are You?";
		string[] s2 = s1.Split(' ');

		foreach(string s3 in s2)
		{
	    	Console.Write(s3);
		}
	}
}