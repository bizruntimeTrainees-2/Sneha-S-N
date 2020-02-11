import { fromEvent } from 'rxjs';
import { scan } from 'rxjs/operators';

fromEvent(document, 'click')
  .pipe(scan(count => count + 2, 0))
  .subscribe(count => console.log(`Clicked ${count} times`));