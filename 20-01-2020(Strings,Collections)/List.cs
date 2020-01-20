using System;
using System.Collections.Generic;

public class List
{
	public static void Main(string[] args)
	{
		var names = new List<string>();
		names.Add("Sneha");
		names.Add("Shweta");
		names.Add("Laxmi");
		names.Add("Sushma");

		foreach(var name in names)
		{
			Console.WriteLine(name);
		}
	}
}
