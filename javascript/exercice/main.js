const Employee = require('./models/Employee')
const Entreprise = require('./models/Entreprise')


let fripouille = new Entreprise();

var employee1 = new Employee(
  1,
  "Torrenti",
  "Sylvain",
  "Dieu",
  80000000,
  new Date("2002-06-28")
);
var employee2 = new Employee(
  2,
  "Crouzet",
  "Gabriel",
  "Portier",
  50000,
  new Date("2002-06-28")
);

var employee3 = new Employee(
  3,
  "Schmitt",
  "Joana",
  "Directrice",
  8000000,
  new Date("2005-01-28")
);

var employee4 = new Employee(
  4,
  "Brown",
  "Tim",
  "Programmeur",
  183000,
  new Date("1520-05-27")
);

var employee5 = new Employee(
  5,
  "Boudier",
  "Aurélien",
  "R&D",
  5000000,
  new Date("2019-03-18")
);

fripouille.create(employee1);
fripouille.create(employee2);
fripouille.create(employee3);
fripouille.create(employee4);
fripouille.create(employee5);

fripouille.delete(4);
fripouille.update(employee2, "maintenance");
fripouille.getLowerSalary(employee2, "1");
console.log("Il y a " + fripouille.length + " employé(e)s.");
console.log(fripouille); // export des employés dans la console
console.log(employee2);
console.log(fripouille.read(3));