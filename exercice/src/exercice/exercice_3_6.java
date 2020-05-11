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
public class exercice_3_6 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.println("veuillez saisir un mot de minimum 5 caractéres:");
		String mot = sc.nextLine();
		if (mot.length() < 5) {
			System.out.println("Le mot ne fait pas 5 caractéres");
		} else {

		}
		sc.close();
	}
}