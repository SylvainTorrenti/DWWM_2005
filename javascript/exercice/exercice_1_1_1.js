const readline = require("readline");
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});
rl.question(
  "\n" + "Saisir deux nombres séparés pas un espace :" + "\n",
  (answer) => {
    let nb = answer.split(" ");
    nb[0] = parseFloat(nb[0]);
    nb[1] = parseFloat(nb[1]);
    let moyenne = (nb[0] + nb[1]) / 2;
    console.log("La moyenne est de : " + moyenne);
  }
);