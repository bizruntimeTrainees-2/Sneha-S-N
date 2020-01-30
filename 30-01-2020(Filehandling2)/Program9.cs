using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp8
{
    class Program9
    {
        static void Main(string[] args)
        {
            string fileName = "E://C#/30-01-2020/BinaryFile.txt";
            using(BinaryWriter bw = new BinaryWriter(File.Open(fileName,FileMode.Create)))
            {
                bw.Write(26);
                bw.Write("BizRunTime Company");
                bw.Write(25.6);
                bw.Write(true);
            }
            Console.WriteLine("Data written successfully");
        }
    }
}
