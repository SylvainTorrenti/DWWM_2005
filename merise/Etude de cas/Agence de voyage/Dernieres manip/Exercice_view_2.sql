use tp_agence_voyages;

DROP VIEW IF EXISTS info_client;
CREATE VIEW info_client
AS
SELECT
C1.client_lastname,
C1.client_firstname,
C1.client_email,
trip_title,
country_name
FROM clients, countries, trips, orders
LEFT JOIN clients AS C1 ON C1.client_id = orders.client_id;



SELECT * FROM info_client;