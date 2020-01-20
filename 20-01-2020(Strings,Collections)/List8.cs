using System;
using System.Collections.Generic;

public class List8
{
	public static void Main(string[] args)
	{
		var names = new LinkedList<string>();
		names.AddLast("Sneha");
		names.AddLast("Shweta");
		names.AddLast("Veena");
		names.AddLast("Subhasa");
		names.AddLast("Sanvi");

		foreach(var name in names)
		{
			Console.WriteLine(name);
		}
	}
}
