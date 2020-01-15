using System;
public class EnumExample1
{
	public enum Season { WINTER = 10, SPRING, SUMMER, FALL}

	public static void Main(string[] args)
	{
		int x = (int)Season.WINTER;
		int y = (int)Season.SUMMER;
		Console.WriteLine("WINTER = {0}", x);
		Console.WriteLine("SUMMER = {0}", y);
	}
}