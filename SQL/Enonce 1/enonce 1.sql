drop database if exists enonce_1;
CREATE database enonce_1;

use enonce_1;

drop table if exists personnes;
CREATE TABLE IF NOT EXISTS personnes (
    personnes_id INT NOT NULL PRIMARY KEY,
    personnes_nom VARCHAR(50) NOT NULL,
    personnes_prenom VARCHAR(50) NOT NULL,
    personnes_no_rue TINYINT NOT NULL,
    personnes_rue VARCHAR(100) NOT NULL,
    personnes_cp TINYINT NOT NULL,
    personnes_ville VARCHAR(50) NOT NULL
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists vehicule;
CREATE TABLE IF NOT EXISTS vehicule (
    personnes_id INT NOT NULL,
    vehicule_immatriculation VARCHAR(7) NOT NULL,
    vehicule_marque VARCHAR(10) NOT NULL,
    vehicule_kilométrage INT NOT NULL,
    vehicule_date_mise_en_service DATE NOT NULL,
    CONSTRAINT pk_vehicule PRIMARY KEY (vehicule_immatriculation),
    CONSTRAINT fk_personne FOREIGN KEY (personnes_id)
        REFERENCES personnes (personnes_id)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;
    

     