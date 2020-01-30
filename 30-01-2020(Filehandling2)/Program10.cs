using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp8
{
    class Program10
    {
        static void Main(string[] args)
        {
            BinaryReader br;
            BinaryWriter bw;
            int i = 125;
            double d = 25.7;
            bool b = true;
            string s = "sneha";
            //writing file
            try
            {
                bw = new BinaryWriter(new FileStream("filedata", FileMode.Create));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + " File could not be created");
                return;
            }

            //writing into file

            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "cannot write into file");
                return;
            }
            bw.Close();

            //reading file

            try
            {
                br = new BinaryReader(new FileStream("filedata", FileMode.Open));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "cannot could not be opened");
                return;
            }

            //reading into file

            try 
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data " +i);
                d = br.ReadDouble();
                Console.WriteLine("Double data " + d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data " + b);
                s = br.ReadString();
                Console.WriteLine("String data " + s);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "cannot write into file");
                return;
            }
            br.Close();
            Console.ReadKey();
        }
    }
}
