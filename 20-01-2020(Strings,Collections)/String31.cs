using System;
using System.Text;

public class String31
{
	public static void Main(string[] args)
	{
		string s1 = "abcdefabcdef";
		char[] ch = {'a','b'};
        int index = s1.LastIndexOfAny(ch);

		Console.WriteLine(index);
	}
}