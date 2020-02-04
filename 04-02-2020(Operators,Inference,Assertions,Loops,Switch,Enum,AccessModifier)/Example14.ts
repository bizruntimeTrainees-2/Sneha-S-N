class Student 
{
    public studCode : number;
    protected studName :string;

    constructor(code:number, name:string)
    {
        this.studCode = 32;
        this.studName = 'Sneha';
    }
}

class Person extends Student
{
    private department : string;

    constructor(code:number, name:string, department:string)
    {
        super(code,name);
        this.department = department;
    }

    public getElevatorPitch()
    {
        return (`My unique code: ${this.studCode}, my name: ${this.studName} and I am in ${this.department} Branch.`);   
    }
}

let Sneha : Person = new Person(1, "Sneha", "CS");
console.log(Sneha.getElevatorPitch());

