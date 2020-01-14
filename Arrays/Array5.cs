//Passing Array to Function
using System;
class Array5
{
   static void printArray(int[] arr)
	{
       Console.WriteLine("Printing the array elements");
	   for(int i = 0; i < arr.Length; i++)
		{
            Console.WriteLine(arr[i]);
		}
	}
	public static void Main(string[] args)
	{
		int[] arr1 = {10,20,30,40,50};
		int[] arr2 = {60,70,80,90,100};
	    
		printArray(arr1);
		printArray(arr2);
	}
}
