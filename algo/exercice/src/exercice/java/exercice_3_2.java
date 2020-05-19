package exercice;

import java.util.Scanner;

public class exercice_3_2 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("Entrez une phrase finissant par . :");
		String phrase = sc.nextLine();
		if (phrase.endsWith(".")) {

			if (phrase == ".") {
				System.out.println("La phrase est vide");

			}
			if (phrase != ".") {

				System.out.println("Choisir une lettre:");
				char lettre = sc.next().charAt(0);

				int occurence = 0;
				for (int i = 0; i < phrase.length(); i++) {
					int count = 0;

					if (phrase.charAt(i) == lettre) {
						count++;
						if (count != 0) {
							occurence++;

							if (occurence > 1) {
								System.out.println("La lettre est presente plusieurs fois.");
								break;

							}
						}
					}
				}
				if (occurence == 0 && phrase.charAt(0) != '.') {
					System.out.println("La lettre n'est pas pr�sente");

				}

				sc.close();

			}

		} else {
			System.out.println("la phrase n'est pas valide");
		}
	}
}
