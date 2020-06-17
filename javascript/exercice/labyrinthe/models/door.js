const Wall = require('./wall.js');

class Door extends Wall {

    /** @var string */
    #isOpen;

    constructor(_x, _y) {
        super(_x, _y);
        this.#isOpen = false;
    }
    getIsOpen() {
        return this.#isOpen;
    }
    openClose() {
        this.#isOpen ? false : true;

    }
}
module.exports = Door;