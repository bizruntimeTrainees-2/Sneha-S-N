using System;
namespace Constructor
{
	public class Employee
	{
		public Employee()
		{
			Console.WriteLine("Constructor Invoked");
		}
		~Employee()
		{
			Console.WriteLine("Destructor Invoked");
		}
	}
class DeStructor
{
	public static void Main(string[] args)
	{
		Employee e1 = new Employee();
		Employee e2 = new Employee();
	}
}
}
