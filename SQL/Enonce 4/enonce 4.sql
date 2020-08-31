drop database if exists enonce_4;
CREATE database enonce_4;

use enonce_4;

drop table if exists livre;
CREATE TABLE IF NOT EXISTS livre (
    livre_ISBN INT PRIMARY KEY NOT NULL,
    livre_titre VARCHAR(100) NOT NULL
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists exemplaire;
CREATE TABLE IF NOT EXISTS exemplaire (
    livre_ISBN INT NOT NULL,
    exemplaire_num INT NOT NULL,
    exemplaire_etat CHAR(1) NOT NULL DEFAULT 'D',
    CONSTRAINT pk_exemplaire_livre PRIMARY KEY (exemplaire_num , livre_ISBN),
    CONSTRAINT fk_livre FOREIGN KEY (livre_ISBN)
        REFERENCES livre (livre_ISBN)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;





