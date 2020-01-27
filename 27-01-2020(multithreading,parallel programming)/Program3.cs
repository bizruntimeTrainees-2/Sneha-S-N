using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp5
{
    public class MyThread2
    {
        public void Thread1()
        {
            Console.WriteLine("One task");
        }
        public void Thread2()
        {
            Console.WriteLine("Two Task");
        }
    }
    public class Program3
    {
        public static void Main(string[] args)
        {
            MyThread2 mt = new MyThread2();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread2));
            t1.Start();
            t2.Start();
        }
    }
}
