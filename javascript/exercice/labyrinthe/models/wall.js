const Point = require('./point.js');

class Wall extends Point {
    /** @var string */
    #material;
    constructor(_x, _y, _material) {
        this.#material(_material);
        super(_x, _y);
    }
}
