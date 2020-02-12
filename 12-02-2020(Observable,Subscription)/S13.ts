import { from } from 'rxjs';

const array = from([10, 20, 30]);
const result = from(array);
const array1 = from(['abc','xyz','pqr']);
const result1 = from(array1);
try{
result.subscribe(x => console.log(x));
result1.subscribe(y => console.log(y));
}
catch(error)
{
  console.log("oh! some went is error");
}















