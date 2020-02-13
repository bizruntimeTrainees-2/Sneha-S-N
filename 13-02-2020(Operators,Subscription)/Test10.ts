import { range } from 'rxjs';
import { single } from 'rxjs/operators';

const numbers = range(1,5).pipe(single(x => x === 10));
numbers.subscribe(x => console.log(x));