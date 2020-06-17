
const Point = require('./models/point.js')
const Wall = require('./models/wall.js')
const Door = require('./models/door.js')
const Path = require('./models/path.js')
const Goal = require('./models/path.js')


const points = [];
var point1 = new Point(1, 1);
var point2 = new Point(2, 2);
var point3 = new Point(3, 3);
var point4 = new Point(4, 4);
var point5 = new Point(5, 5);

points.push(point1, point2, point3, point4, point5);


var wall1 = new Wall(1,1,'wood');

console.log(points);