using System;
public class MemberOverloading3
{
	public int add(int a, int b, int c)
	{
		int sum = a + b + c;
		return sum;
	}
    public double add(double a, double b, double c)
	{
		double sum = a + b + c;
		return sum;
	}
	public static void Main(string[] args)
	{
		MemberOverloading3 MO = new MemberOverloading3();
		int sum1 = MO.add(1,2,5);
		Console.WriteLine("sum of the two integer value : " + sum1);
		double sum2 = MO.add(2.2,4.5,9.7);
		Console.WriteLine("sum of three integer value : " + sum2);
 	}
}