drop database if exists enonce_2;
CREATE database enonce_2;

use enonce_2;

drop table if exists etudiant;
CREATE TABLE IF NOT EXISTS etudiant (
    etudiant_id INT(11) PRIMARY KEY,
    etudiant_nom VARCHAR(50),
    etudiant_prenom VARCHAR(50),
    etudiant_date_e DATE
)ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists matiere;
CREATE TABLE IF NOT EXISTS matiere (
    matiere_id INT(11) PRIMARY KEY,
    matiere_lib VARCHAR(50) UNIQUE,
    matiere_coef VARCHAR(2)
);
drop table if exists controle;
CREATE TABLE IF NOT EXISTS controle (
    etudiant_id INT(11),
    matiere_id INT(11),
    controle_moyenne FLOAT,
    PRIMARY KEY (etudiant_id , matiere_id),
    FOREIGN KEY (etudiant_id)
        REFERENCES etudiant (etudiant_id),
    FOREIGN KEY (matiere_id)
        REFERENCES matiere (matiere_id)
)ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;
    
	
