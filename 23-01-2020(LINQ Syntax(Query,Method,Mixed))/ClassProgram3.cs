using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ClassProgram3
    {
        List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

        var MethodSyntax =
            (from obj in integerList 
            where obj>5 
            select obj).Sum();

        Console.Write("Sum Is : " + MethodSyntax);  
    
            Console.ReadKey();
        }
    }
}
