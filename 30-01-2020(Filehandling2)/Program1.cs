using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp8
{
    class Program1
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"E:\C#\30-01-2020\test.txt", FileMode.OpenOrCreate);
            int i = 0;
            while((i = fs.ReadByte()) != -1)
            {
                Console.WriteLine((char)i);
            }
            fs.Close();
        }
    }
}
