using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        //Create a Text File using a StreamWriter and Write something to the text file
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(@"E:\C#\29-01-2020\Student.txt"))
            {
                sw.WriteLine("Sneha SN");
                sw.WriteLine("Shweta SN");
                sw.WriteLine("Sanvi SN");
                sw.WriteLine("Subhasa CN");
                sw.WriteLine("Hii Hello Bye");
            }

            using (StreamReader sr = new StreamReader(@"E:\C#\29-01-2020\Student.txt"))
            {
                string s;
                do
                {
                    s = sr.ReadLine();
                    Console.WriteLine(s);
                } while (s != null);
            }
        }
    }
}
