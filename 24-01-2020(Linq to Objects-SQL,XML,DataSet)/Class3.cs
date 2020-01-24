using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Class3
    {
        static void Main(string[] args)
        {
            DirectoryInfo filedir = new DirectoryInfo(@"E:\C#");

            var files = from file in filedir.GetFiles()
                        select new { FileName = file.Name, FileSize = (file.Length / 1024) + "K B" };

            Console.WriteLine("FileName" + "\t | " + "FileSize");
            Console.WriteLine("------------------");

            foreach (var item in files)
            {
                Console.WriteLine(item.FileName + "\t | " + "FileSize");
            }

            Console.ReadLine();
        }
    }
}