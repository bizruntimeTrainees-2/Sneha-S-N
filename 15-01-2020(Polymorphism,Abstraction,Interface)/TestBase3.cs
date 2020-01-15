using System;

public class Animal
{
	public virtual void eat()
	{
		Console.WriteLine("eating...");
	}
}

public class Dog : Animal
{
	public override void eat()
	{
		Console.WriteLine("eating bread...");
	}
}

public class TestBase3
{
	public static void Main(string[] args)
	{
          Animal a = new Dog();
		  a.eat();
 	}
}