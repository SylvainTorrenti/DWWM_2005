const Wall = require('./wall.js');

class Door extends Wall {

    

    constructor(_x,_y,_material) {
        super(_x,_y,_material);
        this.isOpen = false;
    }
    getIsOpen() {
        return this.isOpen;
    }
    /* A revoir!!!!
    
    openClose() {
        if (this.isOpen === true) {
          this.isOpen === false;
          return this.isOpen;
        } else {
          this.isOpen === true;
          return this.isOpen;
        }
      }*/
} 
module.exports = Door;