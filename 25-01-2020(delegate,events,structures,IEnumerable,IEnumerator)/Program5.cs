using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    delegate void Transformer(int x);
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            Transformer t = Square; 
                        t += Cuber; //add multicast delegate

                        t -= Square; //remove
                        t.Invoke(i);
                       
            Console.Read();
        }
        public static void Square(int x)
        {
            Console.WriteLine( x * x);
        }

        public static void Cuber(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
}

