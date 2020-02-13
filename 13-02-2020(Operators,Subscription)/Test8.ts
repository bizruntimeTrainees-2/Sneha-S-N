import { fromEvent } from 'rxjs';
import { scan, mapTo } from 'rxjs/operators';

const clicks = fromEvent(document, 'click');
const ones = clicks.pipe(mapTo(1));
const seed = 0;
const count = ones.pipe(scan((acc, one) => acc + one, seed));
count.subscribe(x => console.log(x));