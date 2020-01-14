//Passing Array to Function = print maximum array
using System;
class ArrayMax
{
   static void printMax(int[] arr)
	{
	   int Max = arr[0];
       Console.WriteLine("Printing the Maximum element");
	   for(int i = 1; i < arr.Length; i++)
		{
			if(Max < arr[i])
			{
				Max = arr[i];
			}
		}
		Console.WriteLine("The Maximum Element is : " + Max);
	}
	public static void Main(string[] args)
	{
		int[] arr1 = {9,32,78,29,6,23,97,21,65,3,9,26};
		printMax(arr1);
	}
}
