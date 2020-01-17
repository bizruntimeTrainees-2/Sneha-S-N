using System;

namespace ExceptionHandling
{
	public class Exception4
	{
		 public static void Main(string[] args)  
         {  
             try
             {
                int data=100/0;  
             }
             catch(ArithmeticException e)
			 {
				 Console.WriteLine(e);
			 }  
          Console.WriteLine("rest of the code...");  
		 }
    }  
}  