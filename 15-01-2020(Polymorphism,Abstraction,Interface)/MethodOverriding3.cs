using System;

public class web
{
	string name = "BizRunTime";
	public virtual void showdata()
	{
		Console.WriteLine("Website Name: " + name);
	}
}

public class stream : web
{
	string s = "Software Company";
	public override void showdata()
	{
		base.showdata();
		Console.WriteLine("About: " + s);
	}
}
public class MethodOverriding3
{
	public static void Main(string[] args)
	{
          stream E = new stream();
		  E.showdata();
 	}
}