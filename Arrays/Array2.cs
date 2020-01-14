using System;
class Array2
{
	public static void Main(string[] args)
	{
		//omit the size of array
		int[] arr = new int[]{10,20,30,40,50};
	
		//traversing array
		for(int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
	}
}