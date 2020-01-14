using System;
namespace Constructor
{
	public class Employee
	{
		public int id;
		public String name;
		public float salary;
		public Employee(int i, String n, float s)
		{
			id = i;
			name = n;
			salary = s;
		}
		public void display()
		{
			Console.WriteLine(id + " " + name + " " + salary);
		}
	}
class ParamConstructor
{
	public static void Main(string[] args)
	{
		Employee e1 = new Employee(32, "Sneha", 15000f);
		Employee e2 = new Employee(30, "Shweta", 25000f);
		e1.display();
		e2.display();
	}
}
}
