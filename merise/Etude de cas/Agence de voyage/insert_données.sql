-- DML: manipulation des données
-- INSERT
-- UPDATE
-- DELETE

use tp_trips;

-- vide les tables
truncate table countries;

insert into countries
(country_code,country_name)
values
('fr','France');

-- autre marche aussi!!!!!!!!!!
-- insert into countries
-- values
-- ('fr','France');