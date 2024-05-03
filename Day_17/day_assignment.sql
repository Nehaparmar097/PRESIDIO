use pubs

--1) Print the storeid and number of orders for the store
select s.stor_id, count(o.ord_num) as number_of_orders
from stores s
left join sales o on s.stor_id = o.stor_id
group by s.stor_id;

--2) print the number of orders for every title
select t.title, count(s.ord_num) as num_orders
from titles t
join sales s on t.title_id = s.title_id
group by t.title;

--3) print the publisher name and book name
select p.pub_name, t.title
from publishers p
join titles t on p.pub_id = t.pub_id;

--4) Print the author full name for all the authors
select concat(au_lname, ' ', au_fname) as full_name
from authors;

--5) Print the price of every book with tax (price+price*12.36/100)
select title, price, price + (price * 12.36 / 100) as price_with_tax
from titles;

--6) Print the author name, title name
select concat(a.au_lname, ' ', a.au_fname) as author_name, t.title
from authors a
join titleauthor tk on a.au_id = tk.au_id 
join titles t on t.title_id = tk.title_id;

--7) print the author name, title name and the publisher name
select concat(a.au_lname, ' ', a.au_fname) as author_name, t.title as title_name, p.pub_name
from authors a
join titleauthor ta on a.au_id = ta.au_id 
join titles t on ta.title_id = t.title_id
join publishers p on t.pub_id = p.pub_id;

--8) Print the average price of books published by every publisher
select p.pub_name, avg(t.price) as avg_price
from publishers p
join titles t on p.pub_id = t.pub_id
group by p.pub_name;

--9) print the books published by 'Marjorie'
select * from titles where pub_id in (select pub_id from publishers where pub_name = 'Marjorie');

--10) Print the order numbers of books published by 'New Moon Books'
select distinct o.ord_num
from sales o
join stores od on o.stor_id = od.stor_id
join titles b on o.title_id = b.title_id
join publishers p on b.pub_id = p.pub_id
where p.pub_name = 'New Moon Books';

--11) Print the number of orders for every publisher
select p.pub_name, count(distinct o.title_id) as num_orders
from publishers p
join titles b on p.pub_id = b.pub_id
join titleauthor od on b.title_id = od.title_id
join sales o on b.title_id = o.title_id
group by p.pub_name;

--12) print the order number , book name, quantity, price and the total price for all orders
select o.ord_num, od.title, o.qty, od.price,
       o.qty * od.price as total_price
from sales o
join titles od on o.title_id = od.title_id
join titleauthor b on od.title_id = b.title_id;

--13) print the total order quantity for every book
select b.title, sum(od.qty) as total_order_quantity
from sales od
join titles b on od.title_id = b.title_id
group by b.title;

--14) print the total order value for every book
select b.title, sum(od.qty * b.price) as total_order_value
from sales od
join titles b on od.title_id = b.title_id
group by b.title;

--15) print the orders that are for the books published by the publisher for which 'Paolo' works for
select o.ord_num, od.title
from sales o
join titles od on o.title_id = od.title_id
join titleauthor b on od.title_id = b.title_id
join authors a on b.au_id = a.au_id
where a.au_lname = 'Paolo';
