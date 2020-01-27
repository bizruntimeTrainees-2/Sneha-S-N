using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Program7
    {
        delegate void Transformer(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            Transformer t; // create the instance

            t = delegate (int x) //anonuymous method with keyword delegate
            {
                Console.WriteLine(x * x); 
            };

            //point to the function

            t.Invoke(i);

            Console.ReadLine();
        }
    }
}
