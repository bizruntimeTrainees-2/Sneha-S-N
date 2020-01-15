using System;
public class Calculate
{
	public static int add(int a, int b)
	{
		return a + b;
	}
	public static int add(int a, int b, int c)
	{
		return a + b + c;
	}
}
public class MemberOverloading
{
	public static void Main(string[] args)
	{
		Console.WriteLine(Calculate.add(12, 23));
		Console.WriteLine(Calculate.add(12, 23, 25));
	}
}