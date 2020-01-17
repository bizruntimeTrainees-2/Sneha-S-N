using System;

namespace ExceptionHandling
{
	public class Exception3
	{
		 public static void Main(string[] args)  
         {  
			 try
			 {
				  int a = 10;  
                  int b = 0;  
                  int x = a/b;  
			 }
			 catch (Exception ex)
			 {
                  Console.WriteLine(ex);  
			 }	
        Console.WriteLine("Rest of the code");  
		 }
    }  
}  
