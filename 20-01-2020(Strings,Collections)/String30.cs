using System;
using System.Text;

public class String30
{
	public static void Main(string[] args)
	{
		string s1 = "abcdefabcdef";
		char[] ch = {'c','f'};
        int index = s1.LastIndexOfAny(ch);

		Console.WriteLine(index);
	}
}