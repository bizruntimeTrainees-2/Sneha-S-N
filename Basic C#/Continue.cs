using System;  
public class Continue  
    {  
      public static void Main(string[] args)  
      {  
         for(int i=1;i<=10;i++){    
            if(i==5){    
                continue;    
            }    
            Console.WriteLine(i);    
        }    
      }  
   }  