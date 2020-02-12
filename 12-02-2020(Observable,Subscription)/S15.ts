//Take the first 5 seconds of an infinite 1-second interval Observable

import { interval } from 'rxjs';
import { take } from 'rxjs/operators';

const intervalCount = interval(1000);
const takeFive = intervalCount.pipe(take(10));
takeFive.subscribe(x => console.log(x));  