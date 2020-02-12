import { fromEvent } from 'rxjs';

fromEvent(window, 'mouseout').subscribe(() => console.log('Clicked!'));