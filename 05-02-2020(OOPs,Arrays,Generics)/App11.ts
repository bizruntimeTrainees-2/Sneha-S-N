interface Person
{
    name : string
    age : number
}

interface Employee extends Person
{
    gender : string
    empCode : number
}

let empObject = <Employee>{};
empObject.name = "SnehaSN"
empObject.age = 21
empObject.gender = "Female"
empObject.empCode = 28

console.log("Name: " +empObject.name);
console.log("Employee Code: " + empObject.empCode); 