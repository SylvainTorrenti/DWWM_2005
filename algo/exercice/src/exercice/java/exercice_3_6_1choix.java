package exercice;

import java.util.Scanner;

/**
 * @author Sylvain torrenti
 * @version 1.0
 * @since 11/05/20
 */
public class exercice_3_6_1choix {

	public static void main(String[] args) {

		String mot = "coucou";
		String motIncomplet = "c----u";
		char rep;
		int i, essai;

		Scanner sc = new Scanner(System.in);

		while (!motIncomplet.equals(mot)) {
			for (essai = 0; essai < 6; essai++) {
				System.out.println(motIncomplet);

				System.out.print("Lettre ? ");
				rep = sc.nextLine().charAt(0);
				i = 0;
				while (i < mot.length()) {

					if (mot.charAt(i) == rep)

						motIncomplet = motIncomplet.substring(0, i) + rep + motIncomplet.substring(i + 1);
					i++;

				}
				

			}
			if (essai == 6) {
				System.out.println("Vous avez fait trop d'essais!");
				break;
			}

		}
	}
}