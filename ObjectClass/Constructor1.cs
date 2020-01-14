using System;
namespace Constructor
{
public class Employee
{
	public Employee()
	{
	    Console.WriteLine("Default Constructor invoked");
	}
}
class Constructor1
{
	//Having main() in another class
	public static void Main(string[] args)
	{
		Employee e1 = new Employee();
		Employee e2 = new Employee();
	}
}
}
