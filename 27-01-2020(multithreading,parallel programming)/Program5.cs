using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp5
{
    public class MyThread4
    {
        public void Thread1()
        { 
            for(int i = 0; i < 5; i++)
            {
                 Console.WriteLine(i);
                 Thread.Sleep(200);
            }
        }
    }
    public class Program5
    {
        public static void Main(string[] args)
        {
             MyThread4 mt = new MyThread4();
             Thread t1 = new Thread(new ThreadStart(mt.Thread1));
             Thread t2 = new Thread(new ThreadStart(mt.Thread1));
             Thread t3 = new Thread(new ThreadStart(mt.Thread1));

			 t1.Start();
             t1.Join();
             t2.Start();
             t3.Start();
        }
    }
}
