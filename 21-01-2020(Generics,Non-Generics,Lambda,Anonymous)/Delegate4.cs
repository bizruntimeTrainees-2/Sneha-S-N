using System;
namespace Delegate4
{
public class Delegate4
{
	public delegate void delmethod(int x, int y);

	public class TestMultiDelegate
	{
		public void plus_Method1(int x, int y)
		{
        	 Console.WriteLine("You are in plus_Method");
        	 Console.WriteLine(x + y);
		}

		public void substract_Method2(int x, int y)
		{
        	 Console.WriteLine("You are in substract_Method");
        	 Console.WriteLine(x - y);
		}
	}

public static void Main(string[] args)  
  {
	TestMultiDelegate obj = new TestMultiDelegate();
	delmethod del = new delmethod(obj.plus_Method1);

	del += new delmethod(obj.substract_Method2);
	del(50, 10);
	Console.WriteLine();
	del -= new delmethod(obj.plus_Method1);
	del(20, 10);

	Console.ReadLine();
	}
}
}