using System;
using System.Collections.Generic;

public class List6
{
	public static void Main(string[] args)
	{
		Stack<string> names = new Stack<string>();
		names.Push("Sneha");
		names.Push("Shweta");
		names.Push("Veena");
		names.Push("Subhasa");
		names.Push("Sanvi");

		foreach(string name in names)
		{
			Console.WriteLine(name);
		}

		Console.WriteLine("Peek element: "+names.Peek());
		Console.WriteLine("Pop: "+names.Pop());
		Console.WriteLine("After Pop, Peek element: "+names.Peek());
	}
}
