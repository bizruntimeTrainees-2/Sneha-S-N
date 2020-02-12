import { fromEvent } from 'rxjs';

fromEvent(window, 'mouseout').subscribe(() => alert('Clicked!'));