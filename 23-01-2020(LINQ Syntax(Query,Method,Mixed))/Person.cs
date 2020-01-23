using System;
using System.Collections.generics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namesapce LinqLibrary
{
	public class Person
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }
 
		public int YearsExperiance { get; set; }

		public DateTime Birthday { get; set; }

		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}
	}
}   