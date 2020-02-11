import { Observable } from 'rxjs';

let observable = Observable.create(observer => {
    try 
    {
        observer.next(1);

        setTimeout(() =>
        {
            observer.next(2);
            observer.complete();
            observer.next(3);
        }, 1000)
    }
    catch(error)
    {
        observer.error(error);
    }
})

let subscription = observable.subscribe(
    data => console.log(data),
    error => console.error(error),
    complete => console.log("Done!")
);

