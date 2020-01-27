using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            int j = Program.Square(i);

            Console.WriteLine(j);
            Console.Read();
        }

        static int Square(int x)
        {
            return x * x;
        }
    }
}
