function identity<T>(arg: T) T
{
    return arg;
}

let output1 = identity<string>("myString");
let output2 = identity<number>(100);
console.log(output1);
console.log(output2);


function getItems(items:any[]): any[]
{
    return new Array().concat(items);
}
let myNumArr = getItems([10, 20, 30]);
let myStrArr = getItems(["Hello", "BizRunTime"]);
myNumArr.push(40);
myNumArr.push("Hello Sneha");
myStrArr.push("Hello Shweta");
myStrArr.push(70);


console.log(myNumArr);
console.log(myStrArr);