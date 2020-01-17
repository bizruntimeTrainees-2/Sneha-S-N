using System;  
namespace ExceptionHandling  
{  
    class Exception10  
    {  
        static void Main(string[] args)   
        {  
            checked  
            {  
                int val = int.MaxValue;  
                Console.WriteLine(val + 2);  
            }  
        }  
    }  
}  