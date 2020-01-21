using System;
namespace Delegate3
{
public class Delegate3
{
	public delegate void delmethod();

	public class P
	{
		public static void display()
		{
        	 Console.WriteLine("Hello!");
		}

		public static void show()
		{
        	 Console.WriteLine("Hi!");
		}

		public void print()
		{
        	 Console.WriteLine("Print");
		}
	}
	
public static void Main(string[] args)  
  {
	delmethod del1 = P.show;
	delmethod del2 = new delmethod(P.display);
	P obj = new P();

	delmethod del3 = obj.print;

	del1();
	del2();
	del3();

	Console.ReadLine();
	}
}
}