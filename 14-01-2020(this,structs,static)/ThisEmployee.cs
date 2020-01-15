using System;
namespace thiskeyword
{
public class Employee
{
	public int id;
	public String name;
	public float salary;
	public Employee(int id,String name,float salary)
	{
		this.id = id;
		this.name = name;
		this.salary = salary;
	}
	public void display()
	{
	    Console.WriteLine(id + " " + name + " " + salary);
	}
}
class ThisEmployee
{
	public static void Main(string[] args)
	{
		Employee e1 = new Employee(31, "Sneha", 15000f);
		Employee e2 = new Employee(32, "Shweta", 25000f);
		e1.display();
		e2.display();
	}
}
}
