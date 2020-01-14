using System;
class Array3
{
	public static void Main(string[] args)
	{
		//omit the new operator
		int[] arr = {10,20,30,40,50};
	
		//traversing array
		for(int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
	}
}