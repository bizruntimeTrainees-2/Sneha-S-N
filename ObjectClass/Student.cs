using System;
namespace ObjectClass
{
public class Student
{
	int id;
	String name;
	public static void Main(string[] args)
	{
		Student s1 = new Student();
		s1.id = 32;
		s1.name = "Sneha Narayanadevarakeri";
	     Console.WriteLine(s1.id);
	     Console.WriteLine(s1.name);
	}
}
}
