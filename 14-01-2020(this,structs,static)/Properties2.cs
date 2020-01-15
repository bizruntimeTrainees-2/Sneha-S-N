using System;
public class Employee
{
	private static int counter;

	public Employee()
	{
		counter ++;
	}

	public static int Counter
	{
		get
		{
			return counter;
		}
	}
}
class Properties2
{
	public static void Main(string[] args)
	{
		Employee e1 = new Employee();
		Employee e2 = new Employee();
		Employee e3 = new Employee();
		//e1.Counter = 10;//Compile Time Error: Can't set value

		Console.WriteLine("Number of Employees : " +Employee.Counter);
	}
}