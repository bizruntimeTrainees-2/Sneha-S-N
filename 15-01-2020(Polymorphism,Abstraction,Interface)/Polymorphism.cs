using System;

public class Shape
{
	public virtual void draw()
	{
		Console.WriteLine("drawing...");
	}
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
		Console.WriteLine("drawing circle...");
	}
}
public class Polymorphism
{
	public static void Main(string[] args)
	{
          Shape s;
		  s = new Shape();
		  s.draw();
		  s = new Rectangle();
		  s.draw();
		  s = new Circle();
		  s.draw();
 	}
}