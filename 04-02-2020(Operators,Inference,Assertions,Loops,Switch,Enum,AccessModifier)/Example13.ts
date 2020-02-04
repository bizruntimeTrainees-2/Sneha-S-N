class Student 
{
    public studCode : number;
    private studName :string;

    constructor(code:number, name:string)
    {
        this.studCode = 32;
        this.studName = 'Sneha';
    }

    public display()
    {
        return (`My unique code: ${this.studCode}, my name: ${this.studName}.`);  
    }
}

let student : Student = new Student(1, 'Shweta');
console.log(student.display());

