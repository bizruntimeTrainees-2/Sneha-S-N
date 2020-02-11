import { interval } from 'rxjs';

const observable1 = interval(200);
const observable2 = interval(500);

const subscription = observable1.subscribe(x => console.log('first x:' +x));
const childsubscription = observable2.subscribe(x => console.log('second x:' +x));

subscription.add(childsubscription);

setTimeout(() => {subscription.unsubscribe();
},1000)