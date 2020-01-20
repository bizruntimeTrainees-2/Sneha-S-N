using System;
using System.Collections.Generic;

public class List7
{
	public static void Main(string[] args)
	{
		Queue<string> names = new Queue<string>();
		names.Enqueue("Sneha");
		names.Enqueue("Shweta");
		names.Enqueue("Veena");
		names.Enqueue("Subhasa");
		names.Enqueue("Sanvi");

		foreach(string name in names)
		{
			Console.WriteLine(name);
		}

		Console.WriteLine("Peek element: "+names.Peek());
		Console.WriteLine("Pop: "+names.Dequeue());
		Console.WriteLine("After Pop, Peek element: "+names.Peek());
	}
}
