const Point = require('./point.js');



class Path extends Point {

    /** @var Boolean */
    player;

    /** @var int */
    nbPassages

    constructor(_x, _y, _player, _nbPassages) {
        super(_x, _y);
        this.setPlayer();
        this.setNbPassages();
    }
    getPlayer() {
        return this.player;
    }
    setPlayer(_player) {
        this.player = (typeof (_player) === Boolean) ? _player : false;
    }
    getNbPassages() {
        return this.nbPassages;
    }
    setNbPassages(_nbPassages) {
        this.nbPassages = parseInt(_nbPassages || 0);
    }
}
module.exports = Path;