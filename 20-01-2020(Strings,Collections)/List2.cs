using System;
using System.Collections.Generic;

public class List2
{
	public static void Main(string[] args)
	{
		var names = new HashSet<string>();
		names.Add("Sneha");
		names.Add("Shweta");
		names.Add("Veena");
		names.Add("Subhasa");
		names.Add("Sanvi");

		foreach(var name in names)
		{
			Console.WriteLine(name);
		}
	}
}
