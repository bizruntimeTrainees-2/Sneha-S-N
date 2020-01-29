using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp7
{
    class Program2
    {
        static void Main(string[] args)
        {
            int i = 10;
            double d = 1023.23;
            bool b = true;

            FileStream fs = new FileStream("E://C#/29-01-2020/testdata.txt", FileMode.Create);
            BinaryWriter dataout = new BinaryWriter(fs);
            Console.WriteLine("writing" + i);
            dataout.Write(i);
            Console.WriteLine("writing" + b);
            dataout.Write(b);
            Console.WriteLine("writing" + d);
            dataout.Write(1023.32);
            dataout.Close();
            Console.WriteLine(" ");
            //now read then back
            FileStream fs1 = new FileStream("E://C#/29-01-2020/testdata.txt", FileMode.Open);
            BinaryReader datain = new BinaryReader(fs1);
            i = datain.ReadInt32();
            Console.WriteLine("reading" + i);
            b = datain.ReadBoolean();
            Console.WriteLine("reading" + b);
            d = datain.ReadDouble();
            Console.WriteLine("reading " + 1023.23);
            Console.ReadLine();
            datain.Close();

        }
    }
}
