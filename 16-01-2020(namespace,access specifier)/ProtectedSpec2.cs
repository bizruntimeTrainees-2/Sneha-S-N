using System;  
namespace AccessSpecifiers  
{  
    class ProtectedTest  
    {  
        protected string name = "Shashikant";  
        protected void Msg(string msg)  
        {  
            Console.WriteLine("Hello " + msg);  
        }  
    }  
    class Program : ProtectedTest  
    {  
        static void Main(string[] args)  
        {  
            Program program = new Program();  
            // Accessing protected variable  
            Console.WriteLine("Hello " + program.name);  
            // Accessing protected function  
            program.Msg("Swami Ayyer");  
        }  
    }      
}  