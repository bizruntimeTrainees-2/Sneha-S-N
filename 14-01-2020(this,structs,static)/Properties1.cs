using System;
public class Employee
{
	private string name;

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value + "BizRunTime";
		}
	}
}
class Properties1
{
	public static void Main(string[] args)
	{
		Employee e1 = new Employee();
		e1.Name = "Sneha SN ";
		Console.WriteLine("Employee Name : " +e1.Name);
	}
}