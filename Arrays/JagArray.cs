//Multi-Dimensional array
using System;
class JagArray
{
	public static void Main(string[] args)
	{
		int[][] arr = new int[2][];//declare array

        arr[0] = new int[]{11,21,31,41}; 
		arr[1] = new int[]{12,22,32,42,52,62,72,82};

		for(int i = 0; i < arr.Length; i++)
		{
		    for(int j = 0; j < arr[i].Length; j++)
			{
				Console.Write(arr[i][j] + " ");

			}
			    Console.WriteLine();//new line for each row
		}
	}
}
