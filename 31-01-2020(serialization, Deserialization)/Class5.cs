using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp9
{
    class Class5
    {
        static void Main(string[] args)
        {
            string destination = @"E:\C#\31-01-2020\test2\test.txt";

            string source = @"E:\C#\31-01-2020\test.txt";

            FileInfo fi = new FileInfo(source);

            fi.MoveTo(destination);
            Console.WriteLine("File is Moved");
            Console.WriteLine("File is Moved");

        }
    }
}
