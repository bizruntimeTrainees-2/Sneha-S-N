//params using Array
using System;
namespace Params
{
class ParamsArray
{
	void Show(params int[] val)
	{
		for(int i = 0; i < val.Length; i++)
		{
			 Console.WriteLine(val[i]);
		}
	}
    //Main function, execution entry point of the program
	public static void Main(string[] args)
	{
	     ParamsArray pa = new ParamsArray();
		 pa.Show(2,4,6,9,1,3,5);
	}
}
}
