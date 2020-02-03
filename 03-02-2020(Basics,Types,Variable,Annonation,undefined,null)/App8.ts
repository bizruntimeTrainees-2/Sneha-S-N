interface Calc
{
    substract (first:number, second:number) : any;
}

let Calculator : Calc =
{
    substract(first:number, second:number)
    {
        return first - second;
    }
}