//params using Array
using System;
namespace Params
{
class ObjParamsArray
{
	void Show(params object[] val)
	{
		for(int i = 0; i < val.Length; i++)
		{
			 Console.WriteLine(val[i]);
		}
	}
    //Main function, execution entry point of the program
	public static void Main(string[] args)
	{
	     ObjParamsArray opa = new ObjParamsArray();
		 opa.Show("Shweta", "Sneha", "Rakesh", 21, 63.83,'S');
	}
}
}
