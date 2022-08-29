 --                                         Assignment 7
-------------------------------Questions---------------------------------------------------------------------------------------------------------------------------------------------------
--  Write a query that lists each order number followed by the name of the customer who made the order.
-- Write a query that gives the names of both the salesperson and the customer for each order along with the order number.
-- Write a query that produces all customers serviced by salespeople with a commission above 12%. Output the customer’s name, the salesperson’s name, and the salesperson’s rate of commission.
-- Write a query that calculates the amount of the salesperson’s commission on each order by a customer with a rating above 100.
-- Write a query that produces all pairs of salespeople who are living in the same city.Exclude combinations of salespeople with themselves as well as duplicate rows with the order reversed
-------------------------------Answers-----------------------------------------------------------------------------------------------------------------------------------------------------------

-- use sales;

-- select c.cname,o.onum
-- from customers c,orders o 
-- where o.cnum=c.cnum;

-- select s.sname,c.cname,o.onum
-- from salespeople s,customers c,orders o 
-- where s.snum=o.snum and c.cnum=o.cnum;

-- select c.cname as Customer_Name,s.sname as Salesperson_Name,s.comm as Salesperson_Rate_of_comm
-- from customers c,salespeople s
-- where c.snum=s.snum and comm>0.12;

-- select s.sname,o.amt*s.comm/100 as salespeople_comm
-- from salespeople s,orders o,customers c
-- where s.snum=o.snum and c.cnum=o.cnum and c.rating>100;

-- select s1.*
-- from salespeople s1,salespeople s2
-- where s1.snum!=s2.snum and s1.city=s2.city;