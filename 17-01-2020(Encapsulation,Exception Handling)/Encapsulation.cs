using System;
namespace AccessSpecifier
{
	class Student
	{
		private int id;
		private string name;
		private string email;

		public int ID
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
			    name = value;
			}
		}
		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}
	}
	class Encapsulation
	{
		public static void Main(string[] args)
		{
			Student student = new Student();
			student.ID = 101;
			student.Name = "Sneha S";
			student.Email = "snehasn@BizRun.com";

			Console.WriteLine("ID = "+student.ID);
			Console.WriteLine("Name = "+student.Name);
			Console.WriteLine("Email = "+student.Email);
		}
	}
}