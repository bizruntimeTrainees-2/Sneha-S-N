import { fromEvent } from 'rxjs';
import { filter } from 'rxjs/operators';

const words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];


const result = words.filter(word => word.length > 6);

console.log(result);