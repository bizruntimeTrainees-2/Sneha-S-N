using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class MyThread5
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }
    }
    class Program6
    {
        public static void Main(string[] args)
        {
            MyThread5 mt = new MyThread5();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Name = "Player1";
            t2.Name = "Player2";
            t3.Name = "Player3";
            t1.Start();
            t2.Start();
            t3.Start();

        }
    }
}
