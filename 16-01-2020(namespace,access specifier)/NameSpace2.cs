using System;
using First;
using Second;

namespace First
{
	public class Hello
	{
		public void sayHello()
		{
			Console.WriteLine("Hello Namespace");
		}
	}
}
namespace Second
{
	public class Welcome
	{
		public void sayWelcome()
		{
			Console.WriteLine("Welcome Namespace");
		}
	}
}
    public class NameSpace2
	{
		static void Main(string[] args)
		{
			Hello h1 = new Hello();
			Welcome w1 = new Welcome();
			h1.sayHello();
			w1.sayWelcome();
		}
	}
