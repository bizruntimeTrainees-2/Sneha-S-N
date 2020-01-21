using System;
using System.Collections.Generic;

public class Generic5
{
	public static void Main(string[] args)
	{
         IList<int> intList = new List<int>(){10, 20, 30, 40};
		
		 Console.WriteLine(intList.Count);
         
	 IList<Student> studentList = new List<Student>() 
	 {
		new Student()
		{
			 StudentID = 1, StudentName = "Sneha" 
		},
		new Student()
		{
			StudentID=2, StudentName="Shweta"
		},
        new Student()
	    { 
			StudentID=3, StudentName="Veena"
		},
        new Student()
		{
			StudentID=1, StudentName="Subhasa"
		}
    };		 
		 Console.WriteLine(studentList.Count);

	}
}

public class Student
{
     public int StudentID { get; set; }
	 public string StudentName { get; set; }
}