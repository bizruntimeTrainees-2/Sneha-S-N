using System;
public abstract class Bike
{
    public abstract void run();
}

public class Honda : Bike
{
	public override void run()
	{
		Console.WriteLine("running safely...");
	}
}

public class Abstract1
{
	public static void Main(string[] args)
	{
		Bike obj = new Honda();
		obj.run();
	}
}