use tp_agence_voyages;

DROP VIEW IF EXISTS info_client;
CREATE VIEW info_client 
AS
SELECT 
client_lastname,
client_firstname,
client_email,
trip_title,
country_name
FROM orders 
JOIN clients ON orders.client_id = clients.client_id 
JOIN trips ON orders.trip_code = trips.trip_code
JOIN cities ON trips.city_code = cities.city_code
JOIN countries ON cities.country_code = countries.country_code;


SELECT * FROM info_client;