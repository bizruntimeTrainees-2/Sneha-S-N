interface People
{
    name : string
    age : number
}

interface Celebrity extends People
{
    profession : string
}

function printName<T extends Celebrity>(theInput : T): void
{
    console.log('Name:${theInput.name} \nAge: ${theInput.age} \nProfession: ${theInput.Profession}');
}

let player : Celebrity = 
{
    name : 'Rohit Sharma', age:30, profession:'Cricket Player'
}

printName(player);