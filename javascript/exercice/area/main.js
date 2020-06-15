const Point = require('./models/Points.js');
const Area = require('./models/Area.js');
/**
 * JAVASCRIPT:  Exercices
 * 
 * Coordonnées dans un espace à 2 dimensions type "fenêtre"
 * 
 * 
 * CONSIGNES : 
 * 1) Lisez la description de la classe "Area"
 * 2) Implémentez le code nécessaire à son bon fonctionnement en suivant les indications dans sa descirption
 * 3) Implémentez ensuite le programme suivant :
 *      a) Créer 2 "Area"
 *          a.1) Area 1 : 4 lignes x 4 colonnes
 *          a.2) Area 2 : 8 lignes x 6 colonnes
 *      b) Dans la 1ère "Area", ajouter 8 "Point" (coordonnées au choix, 5 dans les limites de la zone et 3 hors limites)
 *      c) Dans la 2nde "Area", ajouter 6 "Point" (coordonnées au choix, tous en dehors des limites)
 *      d) Créer ensuite 2 "Point" distincts ayant les mêmes coordonnées
 *      e) Les ajouter dans chacune des zones (1 "Point" par zone)
 *      f) Pour chaque zone : 
 *          - Afficher tous les points qui se trouvent hors des limites de la zone
 *          - Exécuter la méthode "needAllInside"
 *          - Afficher tous les points
 *          - Afficher le nombre d'emplacements libres
 * 
 */

//aire 1
const aire_1 = new Area(4, 4);
//aire 2
const aire_2 = new Area(8, 6);

//8 points aire 1
[
    new Point(1, 1),
    new Point(10, 8),
    new Point(11, 5),
    new Point(12, 6),
    new Point(2, 1),
    new Point(3, 4),
    new Point(4, 4),
    new Point(2, 1),
].forEach(a => aire_1.addPoint(a));

//6 points aire 2
[
    new Point(9, 7),
    new Point(8, 8),
    new Point(11, 4),
    new Point(9, 1),
    new Point(10, 5),
    new Point(5, 15),
].forEach(a => aire_2.addPoint(a));


//2 point avec même coordonées
let p1 = new Point(0, 5);
let p2 = new Point(0, 5);

//ajout des points dans les zones
aire_1.addPoint(p1);
aire_2.addPoint(p2);

console.log(aire_1.points);
console.log(aire_2.points);



