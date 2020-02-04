//Type Inference
function sum(a:number, b:number)
{
    return a + b;
}
var total : number = sum(10,20);
var str : string = sum(10,20);

//Type assertion
let code : any = 123;
let employeeCode = <number> code;
console.log(typeof(employeeCode));

let employee = { };
employee.name = "abc";
employee.code = 123;

//Type assertion with Object
interface Employee
{
    name : string;
    code : number;
}

let employee1 = <Employee> { };
employee1.name = "xyz";
employee1.code = 456;


 