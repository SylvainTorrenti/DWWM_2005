/**
 * 
 */
package exercice;

import java.util.Scanner;

/**
 * @author Sylvain torrenti
 * @version 1.0
 * @since 11/05/20
 */
public class exercice_3_5 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("veuillez saisir une phrase.");
		String nom = sc.nextLine();
		sc.close();
		String nom1 = new StringBuilder(nom).reverse().toString();

		if (nom.equals(nom1)) {
			System.out.println(nom + " est un palindrome.");
		} else {
			System.out.println(nom + " n'est pas un palindrome.");

		}

	}
}
