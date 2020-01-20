using System;
using System.Collections.Generic;

public class List5
{
	public static void Main(string[] args)
	{
		var names = new SortedSet<string>(){"Sneha","Shweta","Veena","Subhasa"};

		foreach(var name in names)
		{
			Console.WriteLine(name);
		}
	}
}
