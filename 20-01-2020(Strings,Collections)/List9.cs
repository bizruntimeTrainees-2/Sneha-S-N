using System;
using System.Collections.Generic;

public class List9
{
	public static void Main(string[] args)
	{
		var names = new LinkedList<string>();
		names.AddLast("Veena");
		names.AddLast("Subhasa");
		names.AddLast("Sanvi");

        LinkedListNode<String> node = names.Find("Subhasa");
		names.AddBefore(node, "Sneha");
		names.AddAfter(node, "Shweta");

		foreach(var name in names)
		{
			Console.WriteLine(name);
		}
	}
}
