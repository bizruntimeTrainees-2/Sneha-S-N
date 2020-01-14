//Multi-Dimensional array
using System;
class MultiDimArray2
{
	public static void Main(string[] args)
	{
		int[,] arr = new int[3,3]{{1,2,3},{4,5,6},{7,8,9}};  

		for(int i = 0; i < 3; i++)
		{
		    for(int j = 0; j < 3; j++)
			{
				Console.Write(arr[i,j] + " ");

			}
			    Console.WriteLine();//new line for each row
		}
	}
}
