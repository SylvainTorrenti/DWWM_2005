/**
 * 
 */
package exercice;

import java.util.Scanner;

/**
 * @author sylvain torrenti
 * @since 07/05/20
 * @version 1
 */
public class exercice_3_3_bis {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		int occurrence = 0;

		System.out.println("Veuillez saisir un texte d'au moins 120 caract�res :");
		String texte = sc.nextLine().toLowerCase();

		char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
				's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

		if (texte.length() >= 120) {

			System.out.println("Nombres de lettres :");

			for (int i = 0; i < alphabet.length; i++) {
				for (int j = 0; j < texte.length(); j++) {
					if (texte.charAt(j) == alphabet[i]) {
						occurrence++;
					}
				}
				System.out.println("La lettre " + alphabet[i] + " est pr�sente " + occurrence + " fois");
				occurrence = 0;
			}

		} else {

			System.out.println("Le texte contient moins de 120 caract�res");

		}

		sc.close();
	}
}