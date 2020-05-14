package exercice;

import java.util.Scanner;

/**
 * @author Sylvain torrenti
 * @version 1.0
 * @since 11/05/20
 */
public class exercice3_6 {

	public static void main(String[] args) {
		int essai = 0;
		int i;
		String saisie = "";
		char lettre = ' ';
		boolean juste = false;
		boolean fin = false;
		System.out.println("Entrez un mot d'au moins 5 caractéres:");
		Scanner sc = new Scanner(System.in);
		String mot = sc.nextLine().toUpperCase();
		if (mot.length() >= 5) {

			char[] devine = mot.toCharArray();
			for (i = 0; i < devine.length; i++) {
				devine[i] = '-';
			}

			devine[0] = mot.charAt(0);
			int last = mot.length() - 1;
			devine[last] = mot.charAt(last);

			for (i = 0; i < devine.length; i++) {

				System.out.print(devine[i]);
			}

			System.out.println();

			while (essai < 7 && fin == false) {

				System.out.println("\n" + "Joueur 2 : Saisir une lettre");

				saisie = sc.next().toUpperCase();

				if (saisie.length() > 1) {
					System.out.println("UNE lettre, pas plus ;)");
				} else {

					lettre = saisie.charAt(0);

					for (i = 0; i < devine.length; i++) {

						if (mot.charAt(i) == lettre) {
							devine[i] = lettre;
							juste = true;
						}

					}
					if (juste == true) {
						System.out.println("Lettre présente");
					} else {
						System.out.println("Lettre non présente");
						essai++;
						System.out.println(essai + " tentative(s) restante(s)");
					}
					for (i = 0; i < devine.length; i++) {
						System.out.print(devine[i]);
					}
					System.out.println();

					for (i = 0; i < devine.length; i++) {
						if (devine[i] == '-') {
							fin = false;
							break;
						} else {
							fin = true;
						}
					}
					juste = false;
				}
			}

			if (essai == 7) {
				System.out.println("DEFAITE");
				System.out.println("Le mot était : " + mot);
			}
			if (essai < 7 && fin == true) {
				System.out.println("VICTOIRE");
			}
		}
		sc.close();
	}

}
