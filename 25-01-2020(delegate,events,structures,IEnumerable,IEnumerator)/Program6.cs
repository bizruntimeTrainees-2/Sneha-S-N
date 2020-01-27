using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public delegate void Transformer(int x);

    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            Transformer t; // create the instance

            t = Square; // point to the function
            
            t += Cuber; //two methods till now

            t.Invoke(i); // invoking the delegate

            NotificationofMethods obj = new NotificationofMethods();

            obj.transformerEvent += User1.Xhandler;
            obj.transformerEvent += User2.Yhandler;//U can just subscribe or unsubscribe the event by += or -= operators and nothing else.

            Console.ReadLine();
        }
        public static void Square(int x)
        {
            Console.WriteLine(x * x);
        }
        public static void Cuber(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
    class NotificationofMethods
    {
        public event Transformer transformerEvent;

        public void NotifyOnCell(int x)
        {
            if(transformerEvent != null)
            {
                transformerEvent(x);
            }
        }
    }

    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event received by User1 object");
        }
    }
    class User2
    { 
        public static void Yhandler(int x)
        {
            Console.WriteLine("Event received by User1 object");
        }
    }
}

