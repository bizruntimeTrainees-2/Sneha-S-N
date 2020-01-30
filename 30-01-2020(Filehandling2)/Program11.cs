using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp8
{
    class Program11
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
        static void WriteBinaryFile()
        {
            using(BinaryWriter writer = new BinaryWriter(File.Open("E://C#/30-01-2020/BinaryFile.dat", FileMode.Create)))
            {
                writer.Write(12.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using(BinaryReader reader = new BinaryReader(File.Open("E://C#/30-01-2020/BinaryFile.dat", FileMode.Open)))
            {
                Console.WriteLine("Double value " +reader.ReadDouble());
                Console.WriteLine("String value " +reader.ReadString());
                Console.WriteLine("Boolean value " +reader.ReadBoolean());
            }
        }
    }
}
