import { of } from 'rxjs';
import { max } from 'rxjs/operators';

of(5, 4, 7, 2, 8).pipe(
  max(),
)
.subscribe(x => console.log(x)); 