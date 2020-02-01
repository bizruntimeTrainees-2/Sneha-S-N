using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp9
{
    class Class6
    {
        static void Main(string[] args)
        {
            string path = @"E:\C#\31-01-2020\test.txt";

            FileInfo fi = new FileInfo(path);

            fi.Delete();
            Console.WriteLine("File is deleted");

        }
    }
}
