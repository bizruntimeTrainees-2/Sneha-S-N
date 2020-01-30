using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp8
{
    class Program8
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("E://C#/30-01-2020/textwriter.txt"))
            {
                Console.WriteLine(tr.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
