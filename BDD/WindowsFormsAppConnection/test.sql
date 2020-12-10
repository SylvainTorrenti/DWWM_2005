use Papyrus;

drop table livraison;
create table livraison
(
fournisseur_id char(2),
produits_id char(2),
CONSTRAINT pk_livraison PRIMARY KEY (fournisseur_id , produits_id),
CONSTRAINT fk_fournisseur_livraison FOREIGN KEY (fournisseur_id)
        REFERENCES fournisseur (fournisseur_id),
CONSTRAINT fk_produit_livraison FOREIGN KEY (produits_id)
        REFERENCES produits (produits_id)
);
drop table fournisseur;
create table fournisseur
(
fournisseur_id char(2) primary key,
fournisseur_nom varchar(50),
fournisseur_adresse varchar(100),
fournisseur_cp char(5),
fournisseur_ville varchar(50),
fournisseur_contact varchar(50),
fournisseur_satisfaction Bit,
);

drop table produits
create table produits
(
produits_id char(2) primary key,
produits_label varchar(50),
produits_stock_reel int,
produits_stock_critique int,
produits_qt_annuel int,
produits_mesure varchar(4),
) ;