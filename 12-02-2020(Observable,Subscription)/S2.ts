import { fromEvent } from 'rxjs';

fromEvent(document, 'mouseover').subscribe(() => console.log('Clicked!'));