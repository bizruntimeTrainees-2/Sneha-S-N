using System;
namespace OutParameter
{
	class OutParameter
	{
         //User defined function
		 public void Show(out int val)  //out parameter
		{
			int square = 5;
			val = square;
			val *= val;
		}
		//Main function execution entry point of the program
		static void Main(string[] args)
		{
			int val = 50;
			OutParameter parameter = new OutParameter;
			Console.WriteLine("value before passing out variable" +val);
			parameter.Show(out val);
			Console.WriteLine("value after receiving the out variable" +val);
		}
	}
}