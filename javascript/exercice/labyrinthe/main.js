
const Point = require('./models/point.js')
const Wall = require('./models/wall.js')
const Door = require('./models/door.js')
const Path = require('./models/path.js')
const Goal = require('./models/goal.js')





var wall1 = new Wall(1, 1, 'brick');
console.log(wall1);
console.log(wall1.getMaterial());

var door1 = new Door(2, 2, 'wood');
console.log(door1);
console.log(door1.getIsOpen());
console.log(door1.openClose());


var goal1 = new Goal(3, 3, 'success');
console.log(goal1);
console.log(goal1.getSuccess());

var path1 = new Path(4, 4)
path1.setNbPassages(4);
console.log(path1);
console.log(path1.getPlayer());
console.log(path1.getNbPassages());
path1.setPlayer();
console.log(path1.getPlayer());
path1.setPlayer();
console.log(path1.getPlayer());








