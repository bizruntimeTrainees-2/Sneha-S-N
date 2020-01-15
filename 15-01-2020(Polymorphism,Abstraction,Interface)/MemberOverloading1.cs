using System;
public class Calculate
{
	public static int add(int a, int b)
	{
		return a + b;
	}
	public static float add(float a, float b)
	{
		return a + b;
	}
}
public class MemberOverloading1
{
	public static void Main(string[] args)
	{
		Console.WriteLine(Calculate.add(12, 23));
		Console.WriteLine(Calculate.add(12.4f, 23.2f));
	}
}