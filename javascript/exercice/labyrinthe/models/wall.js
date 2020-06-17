const Point = require('./point.js');

class Wall extends Point {
    /** @var string */
    material;

    constructor(_x,_y,_material) {
        super(_x,_y);
        this.material = _material|| "stone";
    }
    
    getMaterial(){
        return this.material;
    }

}
module.exports = Wall;