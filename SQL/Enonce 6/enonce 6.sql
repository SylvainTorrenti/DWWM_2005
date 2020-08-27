drop database if exists enonce_6;
CREATE database enonce_6;

use enonce_6;

drop table if exists chef;
CREATE TABLE IF NOT EXISTS  chef(
	chef_code int (11) primary key
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists employe;
CREATE TABLE IF NOT EXISTS employe (
    employe_code INT(11) PRIMARY KEY,
    employe_nom VARCHAR(50),
    employe_salaire INT,
    chef_code INT(11),
    FOREIGN KEY (chef_code)
        REFERENCES chef (chef_code)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;
create index ind_nom
on employe (employe_nom);



drop table if exists rayon;
CREATE TABLE IF NOT EXISTS  rayon(
	rayon_nom varchar(50) primary key,
    rayon_etage tinyint
)ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists article;
CREATE TABLE IF NOT EXISTS article (
    article_code INT(10) PRIMARY KEY,
    article_nom VARCHAR(50),
    article_type VARCHAR(50),
    rayon_nom varchar(50),
    FOREIGN KEY (rayon_nom)
        REFERENCES rayon (rayon_nom)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;
create index ind_type
on article (article_type);

drop table if exists fournisseur;
CREATE TABLE IF NOT EXISTS fournisseur (
	fournisseur_code int(10) primary key,
    fournisseur_adresse varchar(50),
    fournisseur_nom varchar(50)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists livraison;
CREATE TABLE IF NOT EXISTS livraison (
    livraison_qt INT,
    fournisseur_code INT(10),
    article_code INT(10),
    PRIMARY KEY (fournisseur_code , article_code),
    FOREIGN KEY (fournisseur_code)
        REFERENCES fournisseur (fournisseur_code),
    FOREIGN KEY (article_code)
        REFERENCES article (article_code)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;
