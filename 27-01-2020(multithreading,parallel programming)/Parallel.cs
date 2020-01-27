using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Parallel
    {
        static void Main()
        {
            var t1 = new Task(() =>  {
                Console.WriteLine("task 1 is beginning");
                Thread.Sleep(2000);
                Console.WriteLine("task 1 has completed");
            });
            t1.Start();

            Console.WriteLine("Press any key quit");
            Console.ReadKey();
        }
    }
}
