using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp8
{
    class Program2
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"E:\C#\30-01-2020\test.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            
            string line = "";
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
            fs.Close();
        }
    }
}
