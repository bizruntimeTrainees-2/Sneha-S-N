using System;
public class String14
{
	public static void Main(string[] args)
	{
		string s2 = "Hello C#";
		CharEnumerator ch = s2.GetEnumerator();

        while(ch.MoveNext())
		{
		   Console.WriteLine(ch.Current);
		}
	}
}