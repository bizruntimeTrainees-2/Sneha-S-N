using System; 
using System.Collections.Generic; 
using System.Linq; 
  
class Student { 
      
    public int rollNo 
    { 
        get; 
        set; 
    } 
      
    public string name 
    { 
        get; 
        set; 
    } 
} 
  
class Example2 { 
      
    static void Main(string[] args) 
    { 
        List<Student> details = new List<Student>() { 
        new Student{ rollNo = 1, name = "Sneha" }, 
        new Student{ rollNo = 2, name = "Shweta" }, 
        new Student{ rollNo = 3, name = "Veena" }, 
        new Student{ rollNo = 4, name = "Subhasa" }, 
        new Student { rollNo = 5, name = "Sanvi" } 
        }; 
  
        
        var newDetails = details.OrderBy(x => x.name); 
  
        foreach(var value in newDetails) 
        { 
            Console.WriteLine(value.rollNo + " " + value.name); 
        } 
    } 
} 