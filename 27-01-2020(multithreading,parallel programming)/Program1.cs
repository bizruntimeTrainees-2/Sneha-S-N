using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace ConsoleApp5
{
   public class MyThread
    {
        public static void Thread1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    public class Program1
    {
       public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
			t1.Start();
			t2.Start();
        }
    }
}
