drop database if exists enonce_5;
CREATE database enonce_5;

use enonce_5;

drop table if exists rayon;
CREATE TABLE IF NOT EXISTS rayon (
    rayon_nom VARCHAR(50) NOT NULL PRIMARY KEY
);

drop table if exists magasin;
CREATE TABLE IF NOT EXISTS magasin (
    magasin_code INT(11) NOT NULL PRIMARY KEY,
    magasin_nom VARCHAR(50) NOT NULL
);

drop table if exists article;
CREATE TABLE IF NOT EXISTS article (
    article_code INT(11) NOT NULL PRIMARY KEY,
    article_nom VARCHAR(50) NOT NULL,
    article_type CHAR(1) NOT NULL
);

drop table if exists vente;
CREATE TABLE IF NOT EXISTS vente (
    vente_num INT(4) NOT NULL PRIMARY KEY,
    vente_quantite INT(4) NOT NULL,
    vente_date_commande DATE NOT NULL,
    rayon_nom VARCHAR(50) NOT NULL,
    article_code INT(11) NOT NULL,
    magasin_code INT(11) NOT NULL,
    FOREIGN KEY (rayon_nom)
        REFERENCES rayon (rayon_nom),
    FOREIGN KEY (magasin_code)
        REFERENCES magasin (magasin_code),
    FOREIGN KEY (article_code)
        REFERENCES article (article_code)
);