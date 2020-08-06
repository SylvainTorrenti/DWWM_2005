

DROP database tp_trips;
CREATE database tp_trips;

use tp_trips;

drop table if exists countries;

create table if not exists countries
(
	country_code char(2) primary key,
    country_name varchar(128) not null
);
