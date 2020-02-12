import { fromEvent } from 'rxjs';

fromEvent(document, 'click').subscribe(() => alert('Clicked!'));