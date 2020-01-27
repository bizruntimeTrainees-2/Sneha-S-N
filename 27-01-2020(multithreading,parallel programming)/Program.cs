using System;
using System.Threading;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";

            Console.WriteLine(t.Name);
        }
    }
}
