using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Employee
    {
 
        public int Eno { get; set; }
        public string Ename { get; set; }
        public int Dno { get; set; }
        public string Dname { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
}
class A
{
    static void Main()
    {
        List<Employee> emps = new List<Employee>()
            {
                new Employee(){Eno=101,Ename="Anil",Salary=20000,Dno=10, Dname="ECE", Designation="AsstProf"},
                new Employee(){Eno=101,Ename="Anil",Salary=20000,Dno=10, Dname="ECE", Designation="AsstProf"},
                new Employee(){Eno=101,Ename="Anil",Salary=20000,Dno=10, Dname="ECE", Designation="AsstProf"},
                new Employee(){Eno=101,Ename="Anil",Salary=20000,Dno=10, Dname="ECE", Designation="AsstProf"},
            };
        Console.WriteLine("1. waq to display Emp details");
        Console.WriteLine("Eno" + "\t" + "Ename" + "\t" + "salary" + "\t" + "Dno" + "\t" + "Dname " + "\t" + "Designation");

        var q1 = from x in emps
                 select x;

        foreach(var item in q1)
        {
            Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary + "\t" + item.Dno + "\t" + item.Dname + "\t" + item.Designation);
        }


        Console.WriteLine("2. waq to display eno,ename,salary working in dno 10");

        var q2 = from x in emps
                 where x.Dno == 10
                 select x;
        foreach (var item in q2)
        {
            Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary);
        }
        Console.WriteLine("waq to display emp details whose sal>20000");
        var q3 = from x in emps
                 where x.salary > 20000
                 select x;

        foreach(var item in q3)
        {
            Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary);
        }

        Console.WriteLine("waq to display emp details who are working in ECE dept and whose>25000");

        var q4 = from x in emps
                 where x.Salary > 25000 && x.Dname == "ECE"
                 select x;
        foreach(var item in q4)
        {
            Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary);
        }
        Console.WriteLine("waq to display emp details in ascending order based on salary");
        var q5 = from x in emps
                 orderby x.Salary ascending
                 select x;
        foreach (var item in q5)
        {
            Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary);
        }

        Console.WriteLine("waq to display emp details in descending order based on salary");
        var q6 = from x in emps
                 orderby x.Salary descending
                 select x;
        foreach (var item in q6)
        {
            Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary);
        }

        Console.WriteLine("waq to display emp details who are working in dno 10 order by salary descending");

        var q7 = from x in emps
                 where x.Dno == 10
                 orderby x.Salary descending
                 select x;
        foreach(var item in q7)
        {
            Console.WriteLine(item.Eno + "\t" + item.Ename + "\t" + item.Salary);
        }

    }
}

