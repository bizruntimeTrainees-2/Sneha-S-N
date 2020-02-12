import { of } from 'rxjs';

of('a', '@#@#', 30, 'sneha', 43, 97, '12', '+-', '')
.subscribe
(
  next => console.log('next:', next),
  complete => console.log('completed'),
  () => console.log('the end')
);













