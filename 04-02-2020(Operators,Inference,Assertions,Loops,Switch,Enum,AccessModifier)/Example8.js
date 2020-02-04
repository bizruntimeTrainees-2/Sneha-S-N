//If statement
var a = 10, b = 20;
if (a < b) {
    console.log('a is less than b');
}
//else-if statement
var n = 10;
if (n > 0) {
    console.log("the value is positive number : " + n);
}
else {
    console.log("the value is negative number : " + n);
}
//if-else-if ladder
var marks = 95;
if (marks < 50) {
    console.log("fail");
}
else if (marks >= 50 && marks < 60) {
    console.log("D grade");
}
else if (marks >= 60 && marks < 70) {
    console.log("C grade");
}
else if (marks >= 70 && marks < 80) {
    console.log("B grade");
}
else if (marks >= 80 && marks < 90) {
    console.log("A grade");
}
else if (marks >= 90 && marks <= 100) {
    console.log("A+ grade");
}
else {
    console.log("Invalid!");
}
var n1 = 10, n2 = 22, n3 = 25;
if (n1 >= n2) {
    if (n1 >= n3) {
        console.log("The largest number is : " + n1);
    }
    else {
        console.log("The largest number is : " + n3);
    }
}
else {
    if (n2 >= n3) {
        console.log("The largest number is : " + n2);
    }
    else {
        console.log("The largest number is : " + n3);
    }
}
