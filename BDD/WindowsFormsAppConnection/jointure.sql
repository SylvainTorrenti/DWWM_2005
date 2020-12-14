select  c.commande_id, c.commande_date, c.commande_commentaire
from commande c
inner join ordre_commande oc on oc.commande_id = c.commande_id
	inner join produits p on oc.produits_id = p.produits_id
		inner join fournisseur f on f.fournisseur_id = p.fournisseur_id
where f.fournisseur_id = 2