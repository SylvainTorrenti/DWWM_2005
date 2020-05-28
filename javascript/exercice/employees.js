/**
 * JAVASCRIPT:  Exercices
 * 
 * Listing d'employés
 * 
 * Consignes : 
 * A l'aide de la syntaxe orientée "classes", modélisez un objet "Employee" possédant les caractéristiques suivantes :
 *  Attributs: 
 *  - id (int): identifiant
 *  - nom (string): nom
 *  - prenom (string): prénom
 *  - email (string): calculé automatiquement dans le constructeur (exemple: John Doe => jdoe@email.fr)
 *  - role (string): poste occupé
 *  - salaire (int): salaire annuel BRUT
 *  - hiredate (Date): date d'embauche au format YYYY-MM-DD
 * 
 *  Méthodes:
 *  - getMonthlysalaire() : retourne un entier -> le salaire mensuel NET calculé à partir du salaire annuel (salaire_mensuel = salaire_annuel / 12 * 0.75)
 *  - getancienity() : renvoie une chaine -> l'ancienneté de l'employé (exemples: "19 jours", "3 mois et 2 jours", "2 ans 7 mois et 8 jours") 
 * 
 * Une fois modélisé et testé, complétez le tableau "employees" pour qu'il contienne 5 employés au total (ni plus, ni moins).
 * Parcourir ensuite le tableau complété et afficher chaque employé dans la console (nom, prénom, email, ancienneté, salaire mensuel NET)
 * Afficher ensuite, individuellement : 
 *  - L'employé ayant le plus d'ancienneté
 *  - L'employé avec le plus haut salaire
 *  - L'employé avec le plus bas salaire
 *  - La différence de salaire entre les 2 précédents 
 * 
 * Documentation Javascript complète: https://developer.mozilla.org/fr/docs/Web/JavaScript
 * Tutoriel Javascript: https://www.pierre-giraud.com/javascript-apprendre-coder-cours/introduction/ 
 */



/* COMPLÉTEZ LE PROGRAMME... */

/**
 * @class Employee
 */

class Employee 
{

    /**
     * Constructeur
     */
    constructor(_id, _lastname, _firstname, _role, _salary, _hiredate) {

        this.id = parseInt(_id); // NaN
        this.lastname = _lastname || "Ano";
        this.firstname = _firstname || "Nymous";
        this.role = _role || "Boulanger";
        this.salary = parseInt(_salary);
        this.hiredate = _hiredate;

        this.email = (this.firstname[0] + this.lastname).toLowerCase() + "@email.fr";
    }

    /**
     * Récupère le salaire mensuel de l'employé
     */
    getMonthlySalary() {
        //(salaire_mensuel = salaire_annuel / 12*0.75)
        return Math.round(this.salary/12*0.75);
    }

    /**
     * 
     */
    getSeniority_Masoud() {

        let now = new Date();
        //let embaucheDate = this.hiredate;
        
        let diff = now.getTime() - this.hiredate.getTime();
        diff = Math.floor(diff/(1000*60*60*24));
        let ans = Math.floor(diff / 365.25);

        diff  = diff - ans*365.25;
        let mois = Math.floor(diff/(365.25/12));

        diff = Math.round(diff - mois*(365.25/12));
        let jour = diff;

        if(jour > 0 && mois > 0 && ans > 0){
            return ans + " ans et " + mois + " mois et " + jour + " jours";
        }else if(jour > 0 && mois > 0 && ans == 0){
            return  mois + " mois et " + jour + " jours";
        } else if (jour > 0 && mois == 0 && ans == 0){
            return jour + " jours";
        }
        else {
            return "L'employé est un alien";
        }
    }

    getSeniority_Aurelien() {
        let now = new Date();
        let diff = now.getTime() - this.hiredate.getTime();
        let year = (1000*3600*24*365.25);
        let month = year/12;
        let day = year/365.25;
        let result = "";

        if(diff < 0) {
            return "L'employé vient du futur.";
        }
        else if(diff % day <= 1) {
            return "L'employé est un newbie.";
        }
        else {
            result += Math.floor(diff/year) + " ";
            diff %= year; // équivalent de "diff = diff % year;"
            result += Math.floor(diff/month) + " ";
            diff %= month;
            result += Math.floor(diff/day) + " ";
            return result;
        }

    }

    getSeniority() {
        let now = new Date(); 
        let y = now.getFullYear() - this.hiredate.getFullYear(); // années
        let m = now.getMonth() - this.hiredate.getMonth(); // mois
        let d = now.getDate() - this.hiredate.getDate(); // jours
        let result = "";

        if(m < 0) {
            y--;
            m += 12;
        }

        if(d < 0) {
            m--;
            d = Math.floor(d + (365.25/12));
        }

        if(y > 0) {
            result += y + " année(s) ";
        }

        if(m > 0) {
            result += m + " mois ";
        }

        if(d > 0) {
            result += d + " jour(s) ";
        }

        return result;

    }
}



module.exports = Employee;


/** DÉBUT ZONE NON EDITABLE (Ne pas modifier les lignes suivantes) */


/** @var Employee employee1 */
var employee1 = new Employee(1, 'Doe', 'John', 'manager', 82000, new Date('2020-12-28').toLocaleDateString()); // création d'un nouvel employé

/** @var array employees */
const employees = [employee1]; // tableau contenant les employés

/*console.log(employee1); // doit afficher l'objet "employee1"
console.log("Il y a " + employees.length + " employé(e)s."); // doit afficher "Il y a 5 employé(e)s."
console.log(employees); // export des employés dans la console


/** FIN ZONE NON EDITABLE (Ne pas modifier les lignes précédentes) */


// Écrivez votre code à partir de la ligne suivante...
/*
var employee2 = new Employee(2, 'Torrenti', 'Sylvain', 'PDG', 150000, new Date('2015-10-12').toLocaleDateString());
var employee3 = new Employee(3, 'Crouzet', 'Gabriel', 'Maintenance', 25000, new Date('2016-05-20').toLocaleDateString());
var employee4 = new Employee(4, 'Schmitt', 'Joanna', 'Cadre', 100000, new Date('2019-10-15').toLocaleDateString());
var employee5 = new Employee(5, 'Brown', 'Timothy', 'Programmeur', 80000, new Date('2017-11-28').toLocaleDateString());

employees.push(employee2, employee3, employee4, employee5);
console.log("Il y a " + employees.length + " employé(e)s.");
console.log(employees);

// comparer ancienneté

let ancien = employees[0];
for (let index = 0; index < employees.length; index++) {
    if (employees[index].hiredate < ancien.hiredate) {
        ancien = employees[index];
    }

}
console.log("L'employé avec le plus d'ancienneté est " + ancien.nom + " " + ancien.prenom);

//L'employé le mieux payé

let hautSalaire = employees[0];
for (let index = 0; index < employees.length; index++) {
    if (employees[index].salaire > hautSalaire.salaire) {
        hautSalaire = employees[index];
    }

}
console.log("L'employé avec le plus haut salaire est " + hautSalaire.nom + " " + hautSalaire.prenom);

//L'employé le moins bien payé

let basSalaire = employees[0];
for (let index = 0; index < employees.length; index++) {
    if (employees[index].salaire < basSalaire.salaire) {
        basSalaire = employees[index];
    }

}
console.log("L'employé avec le plus bas salaire est " + basSalaire.nom + " " + basSalaire.prenom);

//La différence de salaire entre les 2 précédents 

let diffSalaire = hautSalaire.salaire - basSalaire.salaire;
console.log("La différence de salaire entre le plus haut et le plus bas salaire est de " + diffSalaire + " €.");*/