using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Program8
    {
        delegate void Transformer(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            Transformer t; // create the instance

            t = (int x) => { Console.WriteLine(x * x); };

            //point to the function

            t.Invoke(i); // invoking the delegate 

            Console.ReadLine();
        }
    }
}
