using System;  
namespace Exceptionhandling  
{  
    class Exception11 
    {  
        static void Main(string[] args)   
        {  
            unchecked  
            {  
                int val = int.MaxValue;  
                Console.WriteLine(val + 2);  
            }  
        }  
    }  
}  