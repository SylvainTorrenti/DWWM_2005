drop database if exists enonce_4;
CREATE database enonce_4;

use enonce_4;

drop table if exists livre;
CREATE TABLE IF NOT EXISTS livre (
livre_ISBN int(13) primary key not null,
livre_titre varchar(100) not null
);

drop table if exists exemplaire;
CREATE TABLE IF NOT EXISTS exemplaire (
    livre_ISBN INT(13) NOT NULL,
    exemplaire_num INT(3) NOT NULL,
    exemplaire_etat CHAR(1) NOT NULL DEFAULT 'D',
    PRIMARY KEY (exemplaire_num , livre_ISBN),
    FOREIGN KEY (livre_ISBN)
        REFERENCES livre (livre_ISBN)
);





