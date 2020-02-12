import { fromEvent } from 'rxjs';

fromEvent(document, 'mouseout').subscribe(() => console.log('Clicked!'));