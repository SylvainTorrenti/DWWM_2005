package exercice;

import java.util.Scanner;

public class exercie_3_1 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int[] tab = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		System.out.println("Entrez un nombre:");
		int reponse = sc.nextInt();
		for (int i = 0; i < tab.length; i++) {
			if (reponse == tab[i]) {
				System.out.println(i);
				break;
			}
			if (i == tab.length - 1) {
				System.out.println("Non trouvé");
			}
			sc.close();
		}
	}
}
