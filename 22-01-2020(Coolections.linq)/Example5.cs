using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Example5
	{
		public static void Main(string[] args)
		{
			List<Employee> objEmp = new List<Employee>()
			{
				new Employee { EmpId = 1, Name = "Sneha", Location = "Kushtagi" },
				new Employee { EmpId = 2, Name = "Shweta", Location = "Bangalore" },
				new Employee { EmpId = 3, Name = "Veena", Location = "Koppal" },
				new Employee { EmpId = 4, Name = "Subhasa", Location = "Gangavati" },
			};

				var result = from e in objEmp
				where e.Location.Equals("Bangalore")
                select new
			    {
					Name = e.Name,
					Location = e.Location
				};

			foreach (var item in result)
			{
				Console.WriteLine(item.Name + "\t | " + item.Location);
			}
			Console.ReadLine();
			}
	}

	class Employee
	{
		public int EmpId { get; set; }
		public string Name { get; set; }
		public string Location { get; set; }
	}
}
	