using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp8
{
    class Program5
    {
        static void Main(string[] args)
        {
            using (TextWriter wr = File.CreateText("E://C#/30-01-2020/textwriter.txt"))
            {
                for (int i = 0; i < 100; i++)
                {
                    wr.WriteLine("Hii, Good Morning");
                }
            }
            Console.WriteLine("File Created Successfully");
        }
    }
}
