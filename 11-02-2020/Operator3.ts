import { empty, interval, of } from 'rxjs';
import { mergeMap } from 'rxjs/operators';

const interval$ = interval(1000);
const result = interval$.pipe(
  mergeMap(x => x % 2 === 1 ? of('a', 'b', 'c') : empty()),
);
result.subscribe(x => console.log(x));
