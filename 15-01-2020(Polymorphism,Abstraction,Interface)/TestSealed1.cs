using System;

sealed public class Animal
{
	public void eat()
	{
		Console.WriteLine("eating...");
	}
}

public class Dog : Animal
{
    public void bark()
	{
		Console.WriteLine("barking...");
	}
}

public class TestSealed1
{
	public static void Main(string[] args)
	{
          Dog d = new Dog();
		  d.eat();
		  d.bark();
	}
}