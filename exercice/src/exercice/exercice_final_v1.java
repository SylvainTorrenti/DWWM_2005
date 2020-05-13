package exercice;

import java.util.Scanner;

/**
 * @author Sylvain torrenti
 * @version 1.0
 * @since 12/05/20
 */
public class exercice_final_v1 {

	public static int Calcul_PGCD(int a, int b) {

		while (a != b) {
			if (a > b) {
				a = a - b;
			} else {
				b = b - a;
			}

		}
		System.out.println("Le PGCD est de " + a);
		return a;
	}

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("Entrez un nombre:");
		int p = sc.nextInt();
		System.out.println("Entrez un 2eme nombre:");
		int q = sc.nextInt();
		Calcul_PGCD(p, q);
	}
}
