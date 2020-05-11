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
		char devine;
		System.out.println("Entrez un mot d'au moins 5 caractéres:");
		Scanner sc = new Scanner(System.in);
		String mot = sc.nextLine();
		char[] reponse = mot.toCharArray();

		for (i = 0; i < reponse.length; i++) {
			reponse[i] = '-';
			System.out.print(reponse[i]);
		}
		for (i = 0; i < reponse.length; i++) {

			System.out.println("\n" + "Entrez la lettre:");
			devine = sc.next().charAt(0);
			if (mot.charAt(i) == devine) {
				reponse[i] = devine;

			}

		}
	}
}