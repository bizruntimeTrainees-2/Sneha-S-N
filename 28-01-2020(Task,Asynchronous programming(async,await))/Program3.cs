using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("i = " + i);
                Thread.Sleep(1000);
            });
        }
    }
}
