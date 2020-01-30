using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp8
{
    class Program3
    {
        static void Main(string[] args)
        {
            using (TextWriter wr = File.CreateText( "E://C#/30-01-2020/test.txt"))
            {
                wr.WriteLine("Hello to C#");
                wr.WriteLine("File IO Stream");
            }
            Console.WriteLine("File Created Successfully");
        }
    }
}
