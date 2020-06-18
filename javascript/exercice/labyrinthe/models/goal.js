const Point = require('./point.js');



class Goal extends Point {

    /** @var string */
    success;

    constructor(_x,_y,_success) {
        super(_x,_y);
        this.success = _success;
    }
    getSucces() {
        return this.success;
    }

}
module.exports = Goal;