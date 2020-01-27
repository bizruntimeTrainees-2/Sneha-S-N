using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Program2
    {
        delegate int Transformer(int i);
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            Transformer t = Square;

            int j = t(i);

            Console.WriteLine(j);
            Console.Read();
        }

        static int Square(int x)
        {
            return x * x;
        }
    }
}
