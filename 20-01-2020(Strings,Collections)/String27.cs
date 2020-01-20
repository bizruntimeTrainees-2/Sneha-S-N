using System;
using System.Text;

public class String27
{
	public static void Main(string[] args)
	{
		string[] s1 = {"C#",".Net","MySQL","HTML","JavaScript"};
		string s3 = string.Join("-",s1);

		Console.WriteLine(s3);
	}
}