using System;

public class Animal
{
	public Animal()
	{
		Console.WriteLine("animal...");
	}
}

public class Dog : Animal
{
	public Dog()
	{
		Console.WriteLine("dog...");
	}
}

public class TestBase2
{
	public static void Main(string[] args)
	{
          Dog d = new Dog();
 	}
}