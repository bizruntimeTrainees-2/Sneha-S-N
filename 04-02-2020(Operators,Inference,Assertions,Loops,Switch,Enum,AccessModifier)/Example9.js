var Direction;
(function (Direction) {
    Direction[Direction["North"] = 0] = "North";
    Direction[Direction["South"] = 1] = "South";
    Direction[Direction["East"] = 2] = "East";
    Direction[Direction["West"] = 3] = "West";
})(Direction || (Direction = {}));
;
var dir = Direction.West;
function getDirection() {
    switch (dir) {
        case Direction.North:
            console.log('North Direction');
            break;
        case Direction.South:
            console.log('South Direction');
            break;
        case Direction.East:
            console.log('East Direction');
            break;
        case Direction.West:
            console.log('West Direction');
            break;
    }
}
getDirection();
var number = 20;
switch (number) {
    case 10: console.log("10");
    case 10: console.log("20");
    case 10: console.log("30");
    case 10: console.log("40");
}
