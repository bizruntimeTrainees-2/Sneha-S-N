using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{ 
    class Program7
    {
        public static void Main(string[] args)
        {
            
            Thread t1 = new Thread(Print1);
            t1.Start();
           
		     for(int i = 0; i < 1000; i++)
			 {
				 Console.Write(i);
			 }

		   Console.ReadLine();

        }
    public static void Print1()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.Write(i);
        }
    }
	}
}
