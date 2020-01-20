using System;
using System.Collections.Generic;

public class List3
{
	public static void Main(string[] args)
	{
		var names = new HashSet<string>(){"Sneha","Shweta","Veena","Subhasa"};

		foreach(var name in names)
		{
			Console.WriteLine(name);
		}
	}
}
