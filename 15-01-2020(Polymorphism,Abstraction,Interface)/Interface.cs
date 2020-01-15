using System;
public interface Drawable
{
	void draw();
}
public class Rectangle : Drawable
{
	public void draw()
	{
		Console.WriteLine("drawing rectangle...");
	}
}

public class Circle : Drawable
{
	public void draw()
	{	
		Console.WriteLine("drawing Circle...");
	}
}

public class Interface
{
	public static void Main(string[] args)
	{
		Drawable d;
		d = new Rectangle();
		d.draw();
		d = new Circle();
		d.draw();
	}
}