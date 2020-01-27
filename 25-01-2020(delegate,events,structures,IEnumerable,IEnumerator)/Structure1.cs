using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public struct Date
    {
        public int days;
        public int month;
        public int year;

        public void displayDate()
        {
            Console.WriteLine("The date is {0}/{1},{2}", days, month, year);
        }
    }
    class Structure1
    {
        static void Main(string[] args)
        {
            Date dt = new Date();
            dt.days = 31;
            dt.month = 06;
            dt.year = 2019;
            dt.displayDate();
            Console.Read();

        }
    }
}
