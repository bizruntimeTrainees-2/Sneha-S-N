import { timer } from 'rxjs';

const numbers = timer(1000, 500);
numbers.subscribe(x => console.log(x));