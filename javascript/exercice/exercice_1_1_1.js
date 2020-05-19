const readline = require("readline");

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
});

rl.question("Entrez un nombre" + "\n", (answer) => {

    var nombre_1 = answer;
    rl.question("Entre un 2eme nombre" + "\n", (answer2) => {
        var nombre_2 = answer2;

        let moyenne = (parseInt(nombre_1) + parseInt(nombre_2)) / 2;
        console.log(moyenne);
    });

});
