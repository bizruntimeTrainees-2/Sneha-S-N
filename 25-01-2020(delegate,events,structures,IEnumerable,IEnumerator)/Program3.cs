using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Utility
    {
        public static int Square(int x)
        {
            return x * x;
        }
    }
    class Program3
    {
        delegate int Transformer(int i);
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            Transformer t = Utility.Square;

            int j = t(i);

            Console.WriteLine(j);
            Console.Read();
        }

        
    }
}
