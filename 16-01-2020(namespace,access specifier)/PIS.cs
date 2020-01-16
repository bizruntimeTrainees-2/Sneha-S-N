using System; 
public class Parent 
	{ 
         protected internal int value; 
    } 
  
class ABC 
{ 
    public void testAccess() 
    { 
        Parent obj1 = new Parent(); 
        obj1.value = 12; 
    } 
} 
 
namespace PIS { 
  
class Child : Parent { 
  
    public static void Main(String[] args) 
    { 
        Child obj3 = new Child(); 
  
        obj3.value = 9; 
        Console.WriteLine("Value = " + obj3.value); 
    } 
} 
} 