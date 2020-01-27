using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Utility1
    {
        public delegate int Transformer(int x);

        public static int Transform(int x, Transformer t)//type of transform delegate
        {
            return x = t(x);
        }
    }
    class Program4
    {static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            int result = Utility1.Transform(i, Square);
            
            Console.WriteLine(result);
            Console.Read();
        }
        public static int Square(int x)
        {
            return x * x;
        }

        public static int Cuber(int x)
        {
            return x * x * x;
        }
    }
        
}
