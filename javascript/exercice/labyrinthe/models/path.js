const Point = require('./point.js');



class Path extends Point {




    #nbPassages
    #player;
    constructor(_x, _y,) {
        super(_x, _y);

        this.#nbPassages = 0;
        this.#player = false;
    }
    getPlayer() {
        return this.#player;
    }
    /* setPlayer(_player) {
        this.player = _player;
    } */
    getNbPassages() {
        return this.#nbPassages;
    }
    setNbPassages(_nbPassages) {
        this.#nbPassages = parseInt(_nbPassages);
    }
}
module.exports = Path;