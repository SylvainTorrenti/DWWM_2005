
const Point = require('./models/point.js')
const Wall = require('./models/wall.js')
const Door = require('./models/door.js')
const Path = require('./models/path.js')
const Goal = require('./models/goal.js')


const points = [];
var point1 = new Point(1, 1);
var point2 = new Point(2, 2);
var point3 = new Point(3, 3);
var point4 = new Point(4, 4);
var point5 = new Point(5, 5);

points.push(point1, point2, point3, point4, point5);


var wall1 = new Wall(1,1,'wood');
var door1 = new Door(2,2);
var goal1 = new Goal(3,3,'success');
var path1 = new Path(4,4)

console.log(points);
console.log(wall1);
console.log(door1);
console.log(goal1);


path1.setNbPassages(4);
console.log(path1);
