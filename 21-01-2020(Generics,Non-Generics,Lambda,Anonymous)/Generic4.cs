using System;
using System.Collections.Generic;

public class Generic4
{
	public static void Main(string[] args)
	{
         IList<int> intList = new List<int>();
		 intList.Add(10);
		 intList.Add(20);
		 intList.Add(30);
		 intList.Add(40);

		 Console.WriteLine(intList.Count);

		 IList<string> strList = new List<string>();
		 strList.Add("one");
		 strList.Add("two");
		 strList.Add("three");
		 strList.Add("four");
		 strList.Add("four");
		 strList.Add(null);
		 strList.Add(null);

		 Console.WriteLine(strList.Count);
         
		 IList<Student> studentList = new List<Student>();
		 studentList.Add(new Student());
		 studentList.Add(new Student());
		 studentList.Add(new Student());

		 Console.WriteLine(studentList.Count);

	}
}

public class Student
{

}