using System;

namespace ExceptionHandling
{
	public class Exception5
	{
		 public static void Main(string[] args)  
         {  
             try
             {
                int a = 10;
				int b = 0;
				int c = a/b;
             }
             catch(Exception ex)
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