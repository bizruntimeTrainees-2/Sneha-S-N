using System;
namespace statickeyword
{
public class Account
{
	public int accno;
	public String name;
	public static float rateOfInterest = 8.8f;
	public Account(int accno,String name)
	{
		this.accno = accno;
		this.name = name;
	}
	public void display()
	{
	    Console.WriteLine(accno + " " + name + " " + rateOfInterest);
	}
}
class StaticAccount1
{
	public static void Main(string[] args)
	{
		Account.rateOfInterest = 10.5f;//changing value
		Account a1 = new Account(21014,"Sneha");
		Account a2 = new Account(21015,"Shweta");
		a1.display();
		a2.display();
	}
}
}
