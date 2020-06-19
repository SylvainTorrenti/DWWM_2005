const Point = require('./point.js');



class Goal extends Point {

    
    #success;

    constructor(_x,_y,_success) {
        super(_x,_y);
        this.#success = _success;
    }
    getSucces() {
        return this.#success;
    }

}
module.exports = Goal;