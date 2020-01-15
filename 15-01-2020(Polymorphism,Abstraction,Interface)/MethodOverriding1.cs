using System;

public class baseClass
{
	public void show()
	{
		Console.WriteLine("Base Class");
	}
}

public class derived : baseClass
{
	new public void show()
	{
		Console.WriteLine("Derived Class");
	}
}
public class MethodOverriding1
{
	public static void Main(string[] args)
	{
          baseClass obj = new baseClass();
		  obj.show();

		  derived obj1 = new derived();
		  obj1.show();

 	}
}