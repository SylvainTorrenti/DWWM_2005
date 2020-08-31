drop database if exists enonce_6;
CREATE database enonce_6;

use enonce_6;

drop table if exists chef;
CREATE TABLE IF NOT EXISTS  chef(
	chef_code int primary key
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists employe;
CREATE TABLE IF NOT EXISTS employe (
    employe_code INT PRIMARY KEY,
    employe_nom VARCHAR(50),
    employe_salaire INT,
    chef_code INT,
    CONSTRAINT fk_chef FOREIGN KEY (chef_code)
        REFERENCES chef (chef_code)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;
create index ind_nom
on employe (employe_nom);



drop table if exists rayon;
CREATE TABLE IF NOT EXISTS rayon (
    rayon_nom VARCHAR(50) PRIMARY KEY,
    rayon_etage TINYINT
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists article;
CREATE TABLE IF NOT EXISTS article (
    article_code INT PRIMARY KEY,
    article_nom VARCHAR(50),
    article_type VARCHAR(50),
    rayon_nom VARCHAR(50),
    CONSTRAINT fk_rayon FOREIGN KEY (rayon_nom)
        REFERENCES rayon (rayon_nom)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;
create index ind_type
on article (article_type);

drop table if exists fournisseur;
CREATE TABLE IF NOT EXISTS fournisseur (
    fournisseur_code INT PRIMARY KEY,
    fournisseur_adresse VARCHAR(50),
    fournisseur_nom VARCHAR(50)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists livraison;
CREATE TABLE IF NOT EXISTS livraison (
    livraison_qt INT,
    fournisseur_code INT,
    article_code INT,
    CONSTRAINT pk_fournisseur_article PRIMARY KEY (fournisseur_code , article_code),
    CONSTRAINT fk_fournisseur FOREIGN KEY (fournisseur_code)
        REFERENCES fournisseur (fournisseur_code),
    CONSTRAINT fk_article FOREIGN KEY (article_code)
        REFERENCES article (article_code)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;
