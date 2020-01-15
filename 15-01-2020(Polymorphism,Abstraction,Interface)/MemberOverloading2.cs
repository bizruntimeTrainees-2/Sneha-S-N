using System;
public class MemberOverloading2
{
	public int add(int a, int b)
	{
		int sum = a + b;
		return sum;
	}
	public int add(int a, int b, int c)
	{
		int sum = a + b + c;
		return sum;
	}

	public static void Main(string[] args)
	{
		MemberOverloading2 MO = new MemberOverloading2();
		int sum1 = MO.add(1,2);
		Console.WriteLine("sum of the two integer value : " + sum1);
		int sum2 = MO.add(2,4,9);
		Console.WriteLine("sum of three integer value : " + sum2);
 	}
}