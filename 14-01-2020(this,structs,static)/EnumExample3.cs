using System;
public class EnumExample3
{
	public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat};

	public static void Main(string[] args)
	{
		//traversing all values using getNames
		foreach(string s in Enum.GetNames(typeof(Days)))
		{
		  Console.WriteLine(s);
		}
	}
}