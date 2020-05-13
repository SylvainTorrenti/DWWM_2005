package exercice;

import java.util.Scanner;

/**
 * @author Sylvain torrenti
 * @version 1.0
 * @since 12/05/20
 */
public class exercice_3_7 {

	public static void main(String[] args) {
		boolean present = false;
		Scanner sc = new Scanner(System.in);
		String[] nom = { "agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie" };
		System.out.println("Entrez un prénom:");
		String nom1 = sc.nextLine();
		sc.close();
		for (int i = 0; i < nom.length; i++) {
			if (nom[i].equalsIgnoreCase(nom1)) {
				System.out.println(i + 1);
				present = true;
				break;
			}

		}
		if (present == false) {
			System.out.println("Le nom n'est pas présent!");
		}
	}

}
