using System;
namespace Function
{
public class Function  
    {  
	public void Show()
		{
		Console.WriteLine("This is non-parameterized function");
		}
      public static void Main(string[] args)  
      {  
        Function function = new Function();
		function.Show();
      } 
	}
} 