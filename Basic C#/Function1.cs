using System;
namespace Function
{
public class Function1 
    {  
	public void Show(string message)
		{
		Console.WriteLine("Hello " +message);
		}
      public static void Main(string[] args)  
      {  
        Function1 function = new Function1();
		function.Show("Sneha Naraynadevarakeri");
      } 
	}
} 