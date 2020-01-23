using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class ClassProgram4
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>();

            countries.Add("India");
            countries.Add("US");
            countries.Add("Austrailia");
            countries.Add("Shrilanka");

            IEnumerable<string> result = countries.Select(x => x);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
