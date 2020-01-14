//Multi-Dimensional array
using System;
class JagArray1
{
	public static void Main(string[] args)
	{
		int[][] arr = new int[3][]{
        new int[]{11,21,31,41}, 
		new int[]{12,22,32,42,52,62,72,82},
	    new int[]{2,5,6}
		};

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
