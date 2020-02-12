import { Observable } from 'rxjs';

const observable = new Observable(subscriber => {
  subscriber.next(1);
  subscriber.next(2+1);
  subscriber.next(3*5);
setTimeout(() => {
  subscriber.next(4/0);
  subscriber.complete();
}, 1000);
});

console.log('hiii');
observable.subscribe({
  next(x) {
    console.log('got value ' + x);
  },
    error(err) { console.error('something wrong occurred: ' + err);
  },
  complete() { console.log('done'); }
});
