use tp_agences_voyages;

DROP VIEW IF EXISTS info_ville;
CREATE VIEW info_ville 
AS
SELECT DISTINCT
C1.city_code, 
C1.city_name, 
pays.country_code, 
pays.country_name 
FROM cities, countries pays
JOIN cities as C1 on C1.country_code = pays.country_code;

SELECT * FROM info_ville;