using System;
class Array
{
	public static void Main(string[] args)
	{
		int[] arr = new int[12];
		arr[0] = 10;
		arr[1] = 20;
		arr[2] = 30;
		arr[3] = 40;
		arr[4] = 50;
		arr[5] = 60;
		arr[6] = 70;
		arr[7] = 80;
		arr[9] = 80;
		arr[11] = 80;


		//traversing array
		for(int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
	}
}