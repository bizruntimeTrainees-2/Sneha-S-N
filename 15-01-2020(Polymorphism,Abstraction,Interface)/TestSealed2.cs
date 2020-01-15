using System;

public class Animal
{
	public virtual void eat()
	{
		Console.WriteLine("eating...");
	}
	public virtual void run()
	{
		Console.WriteLine("running...");
	}
}

public class Dog : Animal
{
    public override void eat()
	{
		Console.WriteLine("eating bread...");
	}
    public sealed override void run()
	{
		Console.WriteLine("running very fast...");
	}
}

public class BabyDog : Dog
{
	public override void eat()
	{
		Console.WriteLine("eating biscuits...");
	}
	public sealed override void run()
	{
		Console.WriteLine("running slowly...");
	}
}

public class TestSealed2
{
	public static void Main(string[] args)
	{
          BabyDog d = new BabyDog();
		  d.eat();
		  d.run();
	}
}