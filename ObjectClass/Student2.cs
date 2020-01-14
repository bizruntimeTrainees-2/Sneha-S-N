using System;
namespace ObjectClass
{
public class Student
{
	public int id;
	public String name;
	public void insert(int i, String n)
	{
		id = i;
		name = n;
	}
	public void display()
	{
	    Console.WriteLine(id + " " + name);
	}
}
class Student2
{
	public static void Main(string[] args)
	{
		Student s1 = new Student();
		Student s2 = new Student();
		s1.insert(101,"Sneha");
		s2.insert(102,"Shweta");
		s1.display();
		s2.display();
	}
}
}
