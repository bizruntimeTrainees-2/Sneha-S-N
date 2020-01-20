using System;
using System.Text;

public class String41
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#, how Are You?";
		char[] ch = s1.ToCharArray();
        
		foreach(char c in ch)
		{
	        Console.WriteLine(c);
		}
	}
}