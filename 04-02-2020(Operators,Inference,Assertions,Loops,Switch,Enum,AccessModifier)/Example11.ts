let arr = [1, 2, 3, 4, 5];

for(var val of arr)
{
    console.log(val);
}

let str:any = "Bizruntime";
for(let index in str)
{
    console.log('index of ${str[index]}: ${index}');
}

let myArray = [10, 20, 30, 40, 50];
console.log("Output of for..in loop");
for(let val of myArray)
{
    console.log(val);
}

//for-each
let apps = ['WhatsApp', 'Instagram', 'Facebook'];
let playStore = [];

apps.forEach(function(item)
{
    playStore.push(item)
});
console.log(playStore);