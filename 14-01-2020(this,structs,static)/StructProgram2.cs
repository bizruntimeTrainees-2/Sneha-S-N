using System;
public struct Rectangle
{
	public int width, height;

	public Rectangle(int w, int h)
	{
		width = w;
		height = h;
	}
	public void areaOfRectangle()
	{
		Console.WriteLine("Area of Rectangle is : " +(width*height));
	}
}
public class StructProgram2
{
	public static void Main()
	{
		Rectangle r = new Rectangle(5, 6);
		r.areaOfRectangle();
	}
}