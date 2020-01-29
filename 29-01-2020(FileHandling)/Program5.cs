using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp7
{
    class Program5
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("E://C#/29-01-2020/testdata.txt", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("hello C#");
            s.Close();
            s.Close();
            Console.WriteLine("File created successfully...");
        }
    }
}