using System;
public class String9
{
	public static void Main(string[] args)
	{
		string s1 = "Hello C#, How Are You?";
        char[] ch = new char[15];

		s1.CopyTo(10,ch,0,12);
		Console.WriteLine(ch);
	}
}