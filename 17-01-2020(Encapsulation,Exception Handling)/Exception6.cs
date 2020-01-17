using System;

namespace ExceptionHandling
{
	public class Exception6
	{
		 public static void Main(string[] args)  
         {  
             try
             {
                int a = 10;
				int b = 0;
				int c = a/b;
             }
             catch(NullReferenceException ex)
			 {
				 Console.WriteLine(ex);
			 }  
			 finally
			 {
				 Console.WriteLine("Finally Block is Executed");
			 }
          Console.WriteLine("rest of the code...");  
		 }
    }  
}  