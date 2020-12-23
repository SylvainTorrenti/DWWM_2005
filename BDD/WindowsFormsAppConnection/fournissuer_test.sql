CREATE PROCEDURE createfournisseur
(@pfournisseur_nom varchar(50),@pfournisseur_adresse varchar (100), @fournisseur_id int output)
as
insert into fournisseur
values
(@pfournisseur_nom, @pfournisseur_adresse)
set @fournisseur_id=@@IDENTITY