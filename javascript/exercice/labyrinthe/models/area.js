const Point = require('./point.js');
class Area {
    /**
     * Constructeur: Initialise une nouvelle instance de la classe "Area"
     * La largeur et la hauteur définissent respectivement le nombre de colonnes et de lignes. 
     * @param int _width largeur de la zone
     * @param int _height hauteur de la zone
     */
    constructor(_width, _height) {
        this.width = parseInt(_width);
        this.height = parseInt(_height);
        this.size = (this.width * this.height);
        this.point = [];
        
    }

    /**
     * Vérifie si la zone dispose d'emplacements libres
     * @returns Boolean true si au moins 1 emplacement est disponible. false si la zone est pleine
     */
    hasFreeSpace() {
        return (this.point.length < this.size);
    }

    /**
     * Vérifie la disponibilité de l'emplacement aux coordonnées indiquées en argument.
     * @param int _x abscisses
     * @param int _y ordonnées
     * @returns Boolean true si l'emplacement est libre, sinon false.
     */
    isFreeXY(_x, _y) {
        return this.point.find(p => p.x === _x && p.y === _y) === undefined;
    }

    /**
     * Vérifie si l'emplacement aux coordonnées du point fourni en argument est libre.
     * @param Point _point le Point qui contient les coordonnées à contrôler
     * @returns Boolean true si l'emplacement est libre, sinon false.
     */
    isFree(_point) {
        return this.isFreeXY(_point.x, _point.y);
    }

    /**
     * Retourne la 1ère position libre dans la zone
     */
    firstFreeLocation() {

        let result = [];

        for (let x = 0; x < this.width; x++) {
            for (let y = 0; y < this.height; y++) {
                if (this.isFreeXY(x, y)) {
                    result.push(new Point(x, y));
                }
            }
        }

        return result.sort(this.closestFromOrigin)[0];
    }

    /**
     * Vérifie la disponibilité des coordonnées du Point en argument
     * Si emplacement utilisé, déplace le Point vers un emplacement libre
     * @param Point _point 
     */
    moveToFreeLocation(_point) {

        if (!this.isFree(_point)) {
            let free = this.firstFreeLocation();

            if (free !== undefined) {
                _point.copy(free);
            }
        }
    }

    /**
     * Ajoute un "Point" dans la zone
     * Le "Point" peut se trouver hors des limites de la zone
     * @param Point _point 
     * @returns Boolean true en cas de succès, false si l'ajout est impossible 
     */
    addPoint(_point) {

        if (!(_point instanceof Point) || this.hasFreeSpace() === false) {
            return false;
        }

        this.moveToFreeLocation(_point);

        return this.point.push(_point) > 0;
    }


    /**
     * Déplace un point existant dans la zone vers de nouvelles coordonnées
     * Les nouvelles coordonnées peuvent se trouver hors limites
     * @returns Boolean true en cas de succès, false en cas d'échec
     */
    movePoint(/* déterminer les paramètres */) {
        if (!(_point instanceof Point)) {
            return false;
        }
    }


    /**
     * Vérifie la position de chaque "Point" existant dans la zone
     * Chaque Point hors des limites est automatiquement déplacé dans les limites vers la position libre la plus proche du Point d'origine (0,0)
     * @returns int le nombre de points déplacés
     */
    needAllInside() {

        let nb = 0;

        for (let p of this.point) {
            if (p.x >= this.width || p.y >= this.height) {
                this.moveToFreeLocation(p);
                nb++;
            }
        }

        return nb;
    }




}

module.exports = Area;