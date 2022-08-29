 --                                         Assignment 6
-------------------------------Questions---------------------------------------------
--  Write a query that counts the number of salespeople registering orders for each day. (If a salesperson has more than one order on a given day, he or she should be counted only once.).
-- Write a query on the Customers table that will find the highest rating in each city. Put the output in this form: For the city (city), the highest rating is : (rating).
-- Write a query that totals the orders for each day and places the results in descending order.
-- Write a query that selects the total amount in orders for each salesperson for whom this total is greater than the amount of the largest order in the table.
-- Write a query that selects the highest rating in each city. 
-- Largest order taken by each salesperson with order value more than Rs.3000. Select each customer smallest order.

-------------------------------Answers------------------------------------------------

--  use sales;

-- select odate,COUNT(distinct(snum)) as NO_of_salespeople from orders GROUP BY odate; 

-- select city as For_The_City,max(rating) as The_Highest_rating_is from customers GROUP by city;

-- select odate,COUNT(*) as Total_orders from orders GROUP by odate ORDER by count(*) desc;

--   select snum as salesman_id,sum(amt) as Total_amount
--   from orders
--   GROUP BY snum
--   having sum(amt)>(select max(amt) FROM orders);

-- select  city,max(rating) as Highest_rating from customers GROUP by city;

--  select snum,MIN(amt) as smaller_Order
--  from orders 
--  where  amt>3000
--  GROUP BY snum;
