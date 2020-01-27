using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp5
{
    public class MyThread1
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    public class Program2
    {
        public static void Main(string[] args)
        {
            MyThread1 mt = new MyThread1();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t2.Start();
        }
    }
}
