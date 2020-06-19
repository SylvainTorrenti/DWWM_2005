const Wall = require('./wall.js');

class Door extends Wall {

  #isOpen;

  constructor(_x, _y, _material) {
    super(_x, _y, _material);
    this.#isOpen = false;
  }
  getIsOpen() {
    return this.#isOpen;
  }



  openClose() {
    if (this.#isOpen === true) {
      this.#isOpen = false;
      return this.#isOpen;
    } else {
      this.#isOpen = true;
      return this.#isOpen;
    }
  }
}
module.exports = Door;