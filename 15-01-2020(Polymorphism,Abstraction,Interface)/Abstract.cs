using System;
public abstract class Shape
{
    public abstract void draw();
}

public class Rectangle : Shape
{
	public override void draw()
	{
		Console.WriteLine("drawing rectangle...");
	}
}

public class Circle : Shape
{
	public override void draw()
	{
		Console.WriteLine("drawing Cirle...");
	}
}

public class Abstract
{
	public static void Main(string[] args)
	{
		Shape s;
		s = new Rectangle();
		s.draw();
		s = new Circle();
		s.draw();
	}
}