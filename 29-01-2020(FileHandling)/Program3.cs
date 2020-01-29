using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp7
{
    class Program3
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("E://C#/29-01-2020/testdata.txt", FileMode.OpenOrCreate);
            f.WriteByte(65);
            f.Close();
        }
    }
}
