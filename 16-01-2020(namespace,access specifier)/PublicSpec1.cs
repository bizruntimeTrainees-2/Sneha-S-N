using System;

namespace AccessSpecifiers
{
	class PublicStudent
	{
		public int rollNo;
		public string name;

		public PublicStudent(int r,string n)
		{
             rollNo = r;
			 name = n;
		}

		public int getRollNo()
		{
			return rollNo;
		}
		public string getName()
		{
			return name;
		}
	}
    public class PublicSpec1
	{
		static void Main(string[] args)
		{
			PublicStudent student = new PublicStudent(32, "Sneha");
			Console.WriteLine("Roll Number : {0} ," + student.rollNo);
			Console.WriteLine("Name : {0} ," + student.name);
			Console.WriteLine();

            Console.WriteLine("Roll Number : {0} ," + student.getRollNo());
			Console.WriteLine("Name : {0} ," + student.getName());		
		}
	}
}