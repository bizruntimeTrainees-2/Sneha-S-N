//Initialze and Display data through method
using System;
namespace ObjectClass
{
public class Employee
{
	public int id;
	public String name;
	public float salary;
	public void insert(int i, String n,float s)
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
class Employee1
{
	public static void Main(string[] args)
	{
		Employee e1 = new Employee();
		Employee e2 = new Employee();
		e1.insert(101,"Sneha",15000f);
		e2.insert(102,"Shweta",20000f);
		e1.display();
		e2.display();
	}
}
}
