using System;
using System.Collections.Generic;

public class List1
{
	public static void Main(string[] args)
	{
		var names = new List<string>(){"Sneha","Shweta","Veena","Subhasa"};

		foreach(var name in names)
		{
			Console.WriteLine(name);
		}
	}
}
