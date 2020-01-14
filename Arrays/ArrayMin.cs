//Passing Array to Function = print minimum array
using System;
class ArrayMin
{
   static void printMin(int[] arr)
	{
	   int Min = arr[0];
       Console.WriteLine("Printing the Minimum element");
	   for(int i = 1; i < arr.Length; i++)
		{
			if(Min > arr[i])
			{
				Min = arr[i];
			}
		}
		Console.WriteLine("The Minimum Element is : " + Min);
	}
	public static void Main(string[] args)
	{
		int[] arr1 = {9,32,78,29,6,23,97,21,65,3,9,26};
		printMin(arr1);
	}
}
