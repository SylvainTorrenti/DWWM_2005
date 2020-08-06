use ex_editeur;

insert into authors
(author_id,author_firstname,author_lastname,author_pseudo)
values
('1','Sylvain','Torrenti','Moi');
insert into authors
(author_id,author_firstname,author_lastname,author_pseudo)
values
('2','Gabriel','Crouzet','Portier');

insert into books
(book_ISBN, book_title, book_price, book_award)
values
('1452BDS856489','Le secret du magicien','12.99','O');
insert into books
(book_ISBN, book_title, book_price, book_award)
values
('DERF1452BDS85','La tour du magicien','19.99','N');

insert into booksellers
(bookseller_id, bookseller_name, bookseller_adress, bookseller_order)
values
('1','Culura','3 Av du Nord','145 Le secret du magicien et 100 La tour du magicien');

