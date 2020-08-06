-- DQL = langage requête sur les données
-- select
--

use tp_trips;


-- selectionner tous les pays
select * from countries;

select * from countries order by country_name asc;
select * from countries order by country_name desc;