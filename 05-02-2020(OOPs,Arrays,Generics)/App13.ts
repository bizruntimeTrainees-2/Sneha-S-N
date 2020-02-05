interface nameArray
{
    [index:number]:string
}

let myNames : nameArray;
myNames = ['Sneha','Shweta','Veena'];

interface ageArray
{
    [index:number]:number
}

var myAges : ageArray;
myAges = [21,12,28];
console.log("My age is :" +myAges[1]);