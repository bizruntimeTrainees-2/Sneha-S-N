interface Person
{
    name : string
}

interface PersonDetail
{
    age : number
    gender : string
}

interface Employee extends Person, PersonDetail
{
    empCode : number
}

let empObject = <Employee>{};
empObject.name = "SnehaSN"
empObject.age = 21
empObject.gender = "Female"
empObject.empCode = 32

console.log("Name: " +empObject.name);
console.log("Employee Code: " + empObject.empCode); 