using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp7
{
    class Program6
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("E://C#/29-01-2020/testdata.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            f.Close();
        }
    }
}
