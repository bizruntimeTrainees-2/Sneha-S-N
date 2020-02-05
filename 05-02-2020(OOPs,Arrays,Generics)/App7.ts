class Student
{
    studCode : number;
    studname : string;

    constructor(code:number, name:string) 
    {
        this.studCode = code;
        this.studname = name;
    }

    getGrade() : string
    {
        return "A+";
    }
}


class Student1
{
    id : number;
    name : string;

    display() : void
    {
         console.log("Student ID is : " +this.id);
         console.log("Student name is : " +this.name);
    }
    constructor(id:number, name : string)
    {
        this.id = id;
        this.name = name;
    }
}

//By reference variable
let obj = new Student1();
obj.id = 100;
obj.name = "Sneha";

//By method
obj.display();

//By constructor
let obj1 = new Student1(28,"SnehaSN");
obj1.display();

