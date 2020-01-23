using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ClassProgram5
    {
        static void Main()
        {
            //prepare the datasource
            int[] Ar = new int[6] { 2, 3, 4, 5, 6, 10 };
            //write a query the values from Array
            var q1 = from x in Ar;
            select x;
            //Execute the query
            foreach(var item in q1)
            {
                Console.WriteLine(item);
            }
            //waq to display Even no's from the array

            var q2 = from x in Ar
                     where x % 2 == 0
                     select x;
            Console.WriteLine("Even no's are");
            foreach(var item in q2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Odd no's");
            var q3 = from x in Ar
                     where x % 2 != 0
                     select x;

            foreach(var item in q3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("waq to display the values which >5");

            var q4 = from x in Ar
                     where x > 5
                     select x;

            foreach (var item in q4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("waq to display value in Array in ascending order");

            var q5 = from x in Ar
                     orderby x ascending 
                select x;

            foreach (var item in q5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("descending order");

            var q6 = from x in Ar
                     orderby x descending
                     select x;
            foreach(var item in q6)
            {
                Console.WriteLine(item);
            }

        }
    }
}
