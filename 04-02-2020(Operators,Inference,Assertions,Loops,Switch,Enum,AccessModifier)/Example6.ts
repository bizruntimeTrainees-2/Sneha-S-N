let a = 10;
let b = 2;

let c = a + b;
let d = a - b;
let e = a*b;
let f = a/b;
let g = a%b;
let h = a++ + 1;
let i = a-- + 1;
let j = a += b;

console.log(c);
console.log(d);
console.log(e);
console.log(f);
console.log(e);
console.log(h);
console.log(i);
console.log(j);


let p = 10;
let q = 20;
let r = 10;

console.log(p == q);
console.log(p == r);
console.log(p != q);
console.log(p != r);
console.log(p>q);
console.log(q>p);
console.log(p >= r);

let m = false;
let n = true;

console.log(a&&b);

let num = 16;
let result = (num > 0) ? "True":"False";
console.log(result);

let message = "welcome to" + "Bizruntime";
console.log("result of string operator is : " +message);

let Bike = { make: 'Honda', model:'cliq', year:2020};
console.log('make' in Bike);

let Bike1 = { Company1: 'Honda',
             Company2: 'Hero',
             Company3: 'Royal Enfield'
           };
    delete Bike1.Company1;
    console.log(Bike1);