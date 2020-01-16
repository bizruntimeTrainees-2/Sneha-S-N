using System;  
namespace AccessSpecifiers  
{  
    class InternalTest  
    {  
        protected internal string name = "Sneha SN";
		
        protected internal void Msg(string msg)  
        {  
            Console.WriteLine("Hello " + msg);  
        }
		
    }  
    class ProtectedInternalSpec  
    {  
        static void Main(string[] args)  
        {  
            InternalTest it = new InternalTest();  
            Console.WriteLine("Hello " + it.name);  
            it.Msg("Shweta SN");  
        }  
    }  
}  