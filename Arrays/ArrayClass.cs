using System;
namespace Program
{
    class ArrayClass
    {
		static void Main(string[] args)
		{
			int[] arr = new int[6]{5,9,6,2,8,1};
			int[] arr2 = new int[6];

			Console.WriteLine("Length of first array: " +arr.Length);
            //Sorting array
			Array.Sort(arr);
			Console.Write("First Array Elements: ");
			//Displaying sorted array
			PrintArray(arr);
			//Finding index of an array element
			Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr,25));
			//Coping first array to empty array
			Array.Copy(arr, arr2, arr.Length);
			Console.Write("Second array elements: ");
			//Displaying second array
			PrintArray(arr2);
			Array.Reverse(arr);
			Console.Write("\nFirst Array elements in reverse order: ");
			PrintArray(arr);
		}
        static void PrintArray(int[] arr)
		{
			foreach(Object elem in arr)
			{
				Console.WriteLine(elem + " ");
			}
		}
	}
}