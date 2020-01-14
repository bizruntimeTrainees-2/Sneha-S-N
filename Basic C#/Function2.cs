using System;
namespace Function
{
public class Function2 
    {  
	public string Show(string message)
		{
		Console.WriteLine("Inside Show Function");
		return message;
		}
      public static void Main(string[] args)  
      {  
        Function2 function = new Function2();
		string message = function.Show("Sneha Narayanadevarakeri");
		Console.WriteLine("Hello " + message); 
      } 
	}
} 