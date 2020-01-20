using System;
using System.Collections.Generic;

public class List11
{
	public static void Main(string[] args)
	{
		SortedDictionary<string,string> names = new SortedDictionary<string,string>();
		names.Add("1","Sneha");
		names.Add("2","Shweta");
		names.Add("3","Veena");
		names.Add("4","Subhasa");
		names.Add("5","Sanvi");

		foreach(KeyValuePair<string, string> kv in names)
		{
			Console.WriteLine(kv.Key+ " " +kv.Value);
		}
	}
}
