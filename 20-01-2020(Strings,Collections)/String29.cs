using System;
using System.Text;

public class String29
{
	public static void Main(string[] args)
	{
		string s1 = "C# .Net MySQL HTML JavaScripted";
        int first = s1.IndexOf('e');
        int last = s1.LastIndexOf('e');

		Console.WriteLine(first);
		Console.WriteLine(last);
	}
}