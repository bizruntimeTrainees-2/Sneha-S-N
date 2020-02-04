enum Direction
{
    North, South, East, West
};

var dir : Direction = Direction.West; 

function getDirection()
{
    switch(dir)
    {
        case Direction.North : console.log('North Direction');
        break;
        case Direction.South : console.log('South Direction');
        break;
        case Direction.East : console.log('East Direction');
        break;
        case Direction.West : console.log('West Direction');
        break;
    }
}

getDirection();

let number = 20;

switch(number)
{
    case 10 : console.log("10");
    case 20 : console.log("20");
    case 30 : console.log("30");
    default : console.log("not in 10,20 and 30");
}