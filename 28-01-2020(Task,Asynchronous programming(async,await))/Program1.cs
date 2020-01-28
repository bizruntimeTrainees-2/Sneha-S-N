using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp6
{
    class Program1
    {
        static void Main(string[] args)
        {
            var t1 = Task.Factory.StartNew(() => DoWork(1, 2000)).ContinueWith((prev) => DoOtherWork(1, 2000));
            var t2 = Task.Factory.StartNew(() => DoWork(2, 3000));
            var t3 = Task.Factory.StartNew(() => DoWork(3, 1500));

            Console.ReadKey();
        }

        static void DoWork(int id, int sleep)
        {
            Console.WriteLine("Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed...", id);
        }

        static void DoOtherWork(int id, int sleep)
        {
            Console.WriteLine("Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed...", id);
        }
    }
}
