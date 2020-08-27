drop database if exists ex_editeur;
CREATE database ex_editeur;

USE ex_editeur;


drop table if exists booksellers;
create table if not exists booksellers
(
	bookseller_id INT (11) not null primary key,
    bookseller_name varchar(50) not null ,
    bookseller_adress varchar(50) not null ,
    bookseller_order varchar(1000) not null
);

drop table if exists editions;
create table if not exists editions
(
	ed_order INT (3) not null primary key,
    ed_draw_date DATE not null,
    ed_number INT (3) not null
);

drop table if exists books;
create table if not exists books
(
	book_ISBN char(13) not null primary key,
    book_title varchar(50) not null,
    book_price float(4,2) not null,
    book_award char(1) not null
);

drop table if exists authors;
create table if not exists authors
(
	author_id INT (11) not null primary key,
	author_firstname varchar(50) not null ,
	author_lastname varchar(50) not null ,
	author_pseudo varchar(50) not null
);