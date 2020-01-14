using System;
namespace CallByValue
{
public class CallByValue
    {  
	public void Show(int val)
		{
		val *= val;
		Console.WriteLine("Value Inside the show function " +val);
		}
      public static void Main(string[] args)  
      {  
		  int val = 50;
        CallByValue callby = new CallByValue();
		Console.WriteLine("Value before calling the function" + val);
		callby.Show(val);
		Console.WriteLine("Value after calling the function" + val);
      } 
	}
} 