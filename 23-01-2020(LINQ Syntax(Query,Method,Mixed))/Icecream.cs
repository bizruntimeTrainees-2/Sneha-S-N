using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class Icecream
	{
		public string name;
		public string ingredients;
		public string totalFat;
		public string cholesterol;
		public string totalCarbohydrates;
		public string protein;
		public string price;
	}
}

class A
{
	static void Main()
	{
		List<Icecream> icecreamList = new List<Icecream>
	{
		new Icecream
		{
			name = "Chocolate Fudge Icecream",
			ingredients="cream, milk, mono and diglycerides...",
			totalFat="20g",
			cholesterol="50mg",
			totalCarbohydrates="35g",
			protein="4g",
			price=10.5
		},
		new Icecream
		{
			name="Vanilla Icecream",
			ingredients="vanilla extract, guar gum, cream...",
			totalFat="16g",
			cholesterol="65mg",
			totalCarbohydrates="26g",
			protein="4g", price=9.80
		},
		new Icecream
		{
		name="Banana Split Icecream",
		ingredients="Banana, guar gum, cream...",
		totalFat="13g",
		cholesterol="58mg",
		totalCarbohydrates="24g", protein="6g",
		price=7.5
		}
 };

		var IcecreamsWithLessPrice = from ice in icecreamsList
									 where ice.Price < 10
									 select new
									 {
										 Name = ice.Name,
										 Price = ice.Price
									 },
		Console.WriteLine("Ice Creams with price less than 10:");
		foreach (var icecream in IcecreamsWithLessPrice)
		{
			Console.WriteLine("{0} is {1}", icecream.Name,
			icecream.Price);

		}
	}
}