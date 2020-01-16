using System;  
namespace AccessSpecifiers  
{  
    class PrivateTest  
    {  
        private string name = "Sneha SN";  
        private void Msg(string msg)  
        {  
            Console.WriteLine("Hello " + msg);  
        }  
    }  
    class PrivateSpec  
    {  
        static void Main(string[] args)  
        {  
            PrivateTest pt = new PrivateTest();  
            Console.WriteLine("Hello " + pt.name);  
            pt.Msg("Shweta SN");  
        }  
    }  
}  