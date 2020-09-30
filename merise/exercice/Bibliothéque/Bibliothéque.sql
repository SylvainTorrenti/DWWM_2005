drop database if exists bibliotheque;
CREATE database bibliotheque;

use bibliotheque;

drop table if exists deposit;
CREATE TABLE IF NOT EXISTS deposit (
    deposit_id TINYINT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    deposit_amount INT NOT NULL
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists customer;
CREATE TABLE IF NOT EXISTS customer (
    customer_id TINYINT AUTO_INCREMENT NOT NULL PRIMARY KEY,
    customer_firstname VARCHAR(50) NOT NULL,
    customer_lastname VARCHAR(50) NOT NULL,
    customer_adresse VARCHAR(100) NOT NULL,
    deposit_id TINYINT NOT NULL,
    CONSTRAINT fk_deposit FOREIGN KEY (deposit_id)
        REFERENCES deposit (deposit_id)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists book;
CREATE TABLE IF NOT EXISTS book (
    book_number TINYINT NOT NULL PRIMARY KEY,
    book_editor VARCHAR(50) NOT NULL,
    book_buy_date DATE NOT NULL,
    book_state CHAR(1) NOT NULL,
    deposit_id TINYINT NOT NULL,
    CONSTRAINT fk_deposit FOREIGN KEY (deposit_id)
        REFERENCES deposit (deposit_id)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;

drop table if exists loan;
CREATE TABLE IF NOT EXISTS loan (
    book_number TINYINT NOT NULL PRIMARY KEY,
    loan_duration VARCHARACTER(10) NOT NULL,
    loan_date DATE,
    customer_id TINYINT AUTO_INCREMENT NOT NULL,
    CONSTRAINT fk_book FOREIGN KEY (book_number)
        REFERENCES book (book_number),
    CONSTRAINT fk_customer FOREIGN KEY (customer_id)
        REFERENCES customer (customer_id)
)  ENGINE=INNODB CHARSET UTF8 COLLATE UTF8_GENERAL_CI;
