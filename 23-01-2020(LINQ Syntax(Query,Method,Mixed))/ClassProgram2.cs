using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class ClassProgram2
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var MethodSyntax =
                integerList.Where(obj => obj > 5).ToList();
                           
            foreach (var item in MethodSyntax)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
