 --                                         Assignment 8
-------------------------------Questions---------------------------------------------
-- Write a query that uses a subquery to obtain all orders for the customer named Cisneros. Assume you do not know his customer number (cnum).
-- Write a query that produces the names and ratings of all customers who have above- average orders.
-- Write a query that selects the total amount in orders for each salesperson for whom this total is greater than the amount of the largest order in the table.
-- Write a query that selects all customers whose ratings are equal to or greater than ANY of Serres.
-- Write a query using ANY or ALL that will find all salespeople who have no customers located in their city.
-- Write a query that selects all orders for amounts greater than any for the customers in London. 
-- Extract all the orders of Motika.
-- Find all the order attribute to salespeople servicing customers in London.
-- Find names and numbers of all salesperson who have more than one customer.Find salespeople number,name and city who have multiple customers.
-- Select customers who have a greater rating than any other customer in Rome.
-- Select all orders that had amounts that were greater that at least one of the orders from ‘1990-10-04’ .
-- Find all orders with amounts smaller than any amount for a customer in San Jose.
-- Select those customers whose rating are higher than every customer in Paris.
-------------------------------Answers------------------------------------------------

-- use sales;

-- select * from orders where cnum in (select cnum from customers where cname='Cisneros');

-- select cname,rating
-- from customers
-- where rating > (select avg(rating) from customers);

-- select sum(amt),snum
-- from orders 
-- GROUP by snum
-- having sum(amt)>(select MAX(amt) from orders);

-- select * from customers 
-- where rating >=(select rating from customers where cname='Serres');

-- select * from salespeople s,customers c
-- where s.snum=c.snum and s.city!=c.city

-- select * from orders o,customers c 
-- where o.cnum=c.cnum and o.amt>ANY(
--     select amt from orders where cnum in(
--         select cnum from customers where city='London'));

-- select * from orders 
-- where snum=(select snum from salespeople where sname='motika');

-- select * from orders where snum in (select snum from customers where city='London');

-- select sname,snum from salespeople where snum in (select snum from customers GROUP by snum having COUNT(cnum)>1);

-- select c.cname from customers c 
-- where rating > ANY(
--     select rating from customers c 
--     where city='rome');

-- select * from orders where amt > ANY(
--     select amt from orders where odate='1990-10-04');

-- select * from orders 
-- where amt < ANY(
--   select amt from orders where cnum in (
--    select cnum from customers where city='San Jose'));

-- select * from customers where rating > ALL(select rating from customers where city='Paris');