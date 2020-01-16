using System;  
namespace AccessSpecifiers  
{  
    class PrivateSpec1  
    {  
        private string name = "Sneha SN";  

        private void Msg(string msg)  
        {  
            Console.WriteLine("Hello " + msg);  
        }  

       public static void Main(string[] args)  
        {  
            PrivateSpec1 ps = new PrivateSpec1();  
            Console.WriteLine("Hello " + ps.name);  
            ps.Msg("Shweta SN");  
        }  
    }  
}  