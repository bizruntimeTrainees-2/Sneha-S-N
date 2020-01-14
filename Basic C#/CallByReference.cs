using System;
namespace CallByReference
{
public class CallByReference
    {  
	public void Show(ref int val)
		{
		val *= val;
		Console.WriteLine("Value Inside the show function " +val);
		}
      public static void Main(string[] args)  
      {  
		int val = 50;
        CallByReference callby = new CallByReference();
		Console.WriteLine("Value before calling the function" + val);
		callby.Show(ref val);
		Console.WriteLine("Value after calling the function" + val);
      } 
	}
} 