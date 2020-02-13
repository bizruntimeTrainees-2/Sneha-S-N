import { fromEvent } from 'rxjs';
import { bufferCount } from 'rxjs/operators';

const clicks = fromEvent(document, 'click');
const buffered = clicks.pipe(bufferCount(2));
buffered.subscribe(x => console.log(x));