using System;
public class TestSealed3
{
	public static void Main()
	{
		sealed int x = 10;
		x++;
		Console.WriteLine(x);
	}
}