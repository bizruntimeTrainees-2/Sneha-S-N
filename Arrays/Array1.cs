using System;
class Array1
{
	public static void Main(string[] args)
	{
		//initializing array at the time of declaration
		int[] arr = new int[5]{10,20,30,40,50};
	
		//traversing array
		for(int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
	}
}