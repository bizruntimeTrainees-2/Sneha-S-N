import { of } from 'rxjs';
import { min } from 'rxjs/operators';

of(5, 4, 7, 2, 8).pipe(
  min(),
)
.subscribe(x => console.log(x)); 
