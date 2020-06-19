const Point = require('./point.js');



class Goal extends Point {


    #success;

    constructor(_x, _y) {
        super(_x, _y);
        this.#success = true;
    }
    getSuccess() {
        return this.#success;
    }

}
module.exports = Goal;