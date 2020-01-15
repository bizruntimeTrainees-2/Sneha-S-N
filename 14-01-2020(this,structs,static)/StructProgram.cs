using System;

public struct Customer
{
     private int _id;
	 private String _name;

	 public string Name
	{
		 get
		 {
			 return _name;
		 }
         set
         {
			 _name = value;
         }
	}
	public int ID
	{
		get
		{
			return this._id;
		}
		set
		{
			this._id = value;
		}
	}
		 
    public Customer(int Id, String Name)
	{
		this._id = Id;
		this._name = Name;
	}
	public void PrintDetails()
	{
		Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
	}
}
public class StructProgram
{
	public static void Main(string[] args)
	{
		Customer C1 = new Customer(51,"Sneha");
		C1.PrintDetails();

		Customer C2 = new Customer();
		C2.ID = 52;
		C2.Name = "Shweta";
		C2.PrintDetails();

		Customer C3 = new Customer
		{
			ID = 53,
			Name = "Rob"
		};
		C3.PrintDetails();
	}
}