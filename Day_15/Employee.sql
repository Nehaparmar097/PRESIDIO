create database Employees
use Employees
--creating item table
CREATE TABLE ITEM (
    itemname VARCHAR(255) PRIMARY KEY,
    itemtype VARCHAR(100),
    itemcolor VARCHAR(100)
);
--creating employee table

  
create table empp (
    empno int   primary key,
    empname varchar(255),
    salary decimal(10, 2),
    deptname varchar(255),
    bossno int
);

--creating department table
create table departmentt (
    deptname varchar(255) primary key,
    floor varchar(50),
    phone varchar(20),
    empno int not null
);
--creating slaes table , refering to item and department

CREATE TABLE SALES (
    salesno INT PRIMARY KEY,
    saleqty INT,
    itemname VARCHAR(255) NOT NULL,
    deptname VARCHAR(255) NOT NULL
);
--inserting values into emp table
INSERT INTO empp (empno, empname, salary, deptname, bossno) VALUES
(1, 'Alice', 75000, 'Management', NULL),
(2, 'Ned', 45000, 'Marketing', 1),
(3, 'Andrew', 25000, 'Marketing', 2),
(4, 'Clare', 22000, 'Marketing', 2),
(5, 'Todd', 38000, 'Accounting', 1),
(6, 'Nancy', 22000, 'Accounting', 5),
(7, 'Brier', 43000, 'Purchasing', 1),
(8, 'Sarah', 56000, 'Purchasing', 7),
(9, 'Sophile', 35000, 'Personnel', 1),
(10, 'Sanjay', 15000, 'Navigation', 3),
(11, 'Rita', 15000, 'Books', 4),
(12, 'Gigi', 16000, 'Clothes', 4),
(13, 'Maggie', 11000, 'Clothes', 4),
(14, 'Paul', 15000, 'Equipment', 3),
(15, 'James', 15000, 'Equipment', 3),
(16, 'Pat', 15000, 'Furniture', 3),
(17, 'Mark', 15000, 'Recreation', 3);


--inserting into department table 
INSERT INTO DEPARTMENTT (deptname, floor, phone, empno) VALUES
('Management', 5, '34', 1),
('Books', 1, '81', 4),
('Clothes', 2, '24', 4),
('Equipment', 3, '57', 3),
('Furniture', 4, '14', 3),
('Navigation', 1, '41', 3),
('Recreation', 2, '29', 4),
('Accounting', 5, '35', 5),
('Purchasing', 5, '36', 7),
('Personnel', 5, '37', 9),
('Marketing', 5, '38', 2);


--adding references (froenkey)
alter table empp
add constraint fk_deptnam foreign key (deptname)
references departmentt(deptname) on delete set null;

alter table empp
add constraint fk_bossnokey foreign key (bossno)
references empp(empno) on delete no action;

alter table departmentt
add constraint fk_empnokey foreign key (empno)
references empp(empno) ;
--insert into items table 
INSERT INTO ITEM (itemname, itemtype, itemcolor) VALUES
('Pocket Knife-Nile', 'E', 'Brown'),
('Pocket Knife-Avon', 'E', 'Brown'),
('Compass', 'N', NULL),
('Geo positioning system', 'N', NULL),
('Elephant Polo stick', 'R', 'Bamboo'),
('Camel Saddle', 'R', 'Brown'),
('Sextant', 'N', NULL),
('Map Measure', 'N', NULL);


--inserting into sales table
INSERT INTO SALES (salesno, saleqty, itemname, deptname) VALUES
(101, 2, 'Boots-snake proof', 'Clothes'),
(102, 1, 'Pith Helmet', 'Clothes'),
(103, 1, 'Sextant', 'Navigation'),
(104, 3, 'Hat-polar Explorer', 'Clothes'),
(105, 5, 'Pith Helmet', 'Equipment'),
(106, 2, 'Pocket Knife-Nile', 'Clothes'),
(107, 3, 'Pocket Knife-Nile', 'Recreation'),
(108, 1, 'Compass', 'Navigation'),
(109, 2, 'Geo positioning system', 'Navigation'),
(110, 5, 'Map Measure', 'Navigation'),
(111, 1, 'Geo positioning system', 'Books'),
(112, 1, 'Sextant', 'Books'),
(113, 3, 'Pocket Knife-Nile', 'Books'),
(114, 1, 'Pocket Knife-Nile', 'Navigation'),
(115, 1, 'Pocket Knife-Nile', 'Equipment'),
(116, 1, 'Sextant', 'Clothes'),
(117, 1, 'Pocket Knife-Nile', 'Equipment'),
(118, 1, '', 'Recreation'),
(119, 1, '', 'Furniture'),
(120, 1, 'Pocket Knife-Nile', ''),
(121, 1, 'Exploring in 10 easy lessons', 'Books'),
(122, 1, 'How to win foreign friends', ''),
(123, 1, 'Compass', ''),
(124, 1, 'Pith Helmet', ''),
(125, 1, 'Elephant Polo stick', 'Recreation'),
(126, 1, 'Camel Saddle', 'Recreation');


alter table sales
add constraint itemnameFK foreign key (itemname)
references ITEM(itemname) ;

alter table sales
add constraint fk foreign key (deptname)
references DEPARTMENTT(deptname);

select *from empp
select *from departmentt
select *from sales
select * from ITEM