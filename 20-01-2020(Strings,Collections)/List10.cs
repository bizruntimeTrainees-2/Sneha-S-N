using System;
using System.Collections.Generic;

public class List10
{
	public static void Main(string[] args)
	{
		Dictionary<string,string> names = new Dictionary<string,string>();
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
