drop database if exists enonce_3;
CREATE database enonce_3;

use enonce_3;

drop table if exists etudiant;
CREATE TABLE IF NOT EXISTS etudiant (
    etudiant_id INT NOT NULL PRIMARY KEY,
    etudiant_nom VARCHAR(50) NOT NULL,
    etudiant_prenom VARCHAR(50) NOT NULL,
    etudiant_date_entree DATE NOT NULL
)ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists matiere;
CREATE TABLE IF NOT EXISTS matiere (
    matiere_id INT PRIMARY KEY NOT NULL,
    matiere_lib VARCHAR(50) UNIQUE NOT NULL,
    matiere_coef VARCHAR(2) NOT NULL
)ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists controle;
CREATE TABLE IF NOT EXISTS controle (
    controle_date DATE NOT NULL,
    controle_moyenne DECIMAL(4 , 2 ) NOT NULL,
    matiere_id INT NOT NULL,
    etudiant_id INT NOT NULL,
    CONSTRAINT pk_conmatetu PRIMARY KEY (controle_date , matiere_id , etudiant_id),
    CONSTRAINT fk_matiere FOREIGN KEY (matiere_id)
        REFERENCES matiere (matiere_id),
    CONSTRAINT fk_etudiant FOREIGN KEY (etudiant_id)
        REFERENCES etudiant (etudiant_id)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

    