use tp_agences_voyages;

DROP VIEW IF EXISTS info_ville;
CREATE VIEW info_ville 
AS
SELECT cities.*, countries.country_name
FROM countries
JOIN cities ON cities.country_code = countries.country_code;

SELECT * FROM info_ville;


