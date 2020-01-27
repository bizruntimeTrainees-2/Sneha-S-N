using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;

namespace ConsoleApp5
{
    class Parallel1
    {
        static void Main()
        {
            var t1 = new Task(() => DoSomeVeryImportantWork(1, 1500));
            t1.Start();
            var t2 = new Task(() => DoSomeVeryImportantWork(2, 3000));
            t2.Start();
            var t3 = new Task(() => DoSomeVeryImportantWork(3, 1000));
            t3.Start();

            Console.WriteLine("Press any key quit");
            Console.ReadKey();
        }

        static void DoSomeVeryImportantWork(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is beginning", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} has completed", id);

        }
    }

}
