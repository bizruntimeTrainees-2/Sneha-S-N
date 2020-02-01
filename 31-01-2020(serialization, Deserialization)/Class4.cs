using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp9
{
    class Class4
    {
        static void Main(string[] args)
        {
            string destination = @"E:\C#\31-01-2020\test2\test.txt";

            string source = @"E:\C#\31-01-2020\test.txt";

            FileInfo fi = new FileInfo(source);

            fi.CopyTo(destination);
            Console.WriteLine("File is Copied");

        }
    }
}
