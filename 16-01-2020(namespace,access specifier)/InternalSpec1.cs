using System;

namespace AccessSpecifiers
{
	internal class InternalTest
	{
        int real;
		int img;

		public void setData(int r, int i)
		{
             real = r;
			 img = i;
		}

		public void displayData()
		{
			Console.WriteLine("Real = {0}", real);
			Console.WriteLine("Imaginary = {0}", img);
		}
	}
		
    class InternalSpec1
	{
		static void Main(string[] args)
		{
			InternalTest it = new InternalTest();
			it.setData(2, 1);	
			it.displayData();	
		}
	}
}