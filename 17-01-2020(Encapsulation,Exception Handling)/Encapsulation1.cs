using System;
using System.Text;

namespace AccessSpecifier
{
	class User
	{
		private string location;
		private string name;

		public string Location
		{
			get
			{
				return location;
			}
			set
			{
				location = value;
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
	}
	class Encapsulation1
	{
		public static void Main(string[] args)
		{
			User u = new User();
			u.Name = "Sneha";
			u.Location = "Kushtagi";

			Console.WriteLine("Name = "+u.Name);
			Console.WriteLine("Location = "+u.Location);
			Console.WriteLine("\nPress Enter Key to Exit..");
			Console.ReadLine();
		}
	}
}