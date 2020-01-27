using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp5
{
    public class MyThread3
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
				Thread.Sleep(200);
            }
        }
    }
    public class Program4
    {
        public static void Main(string[] args)
        {
            MyThread3 mt = new MyThread3();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t2.Start();
        }
    }
}
