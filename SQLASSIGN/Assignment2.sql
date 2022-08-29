 --                       Assignment 2
-------------------------------Questions---------------------------------------------
--    create 'product_db' databse
-- create following tables
-- categories: id (PK), title, description
-- products: id (PK), title, price, description, category (FK), company
-- orders: id (PK), total, date
-- order_details: id (PK), orderId (FK), productId (FK), quantity, price, totalPrice, discount
-- create relationship as shown in the table schema
-- add some dummy data

-------------------------------Answers------------------------------------------------


-- CREATE DATABASE product_db;

-- USE product_db;

--  CREATE TABLE categories (
--      id int PRIMARY KEY IDENTITY(1,1),
--      title varchar(20),
--      Description varchar(20)
--  );

--  CREATE TABLE products (
--      id int PRIMARY KEY IDENTITY(11,1),
--      title varchar(20),
--      price INT,
--      description varchar(20),
--      category int FOREIGN KEY REFERENCES categories (id) on delete cascade,
--      company Varchar(20)
--  );

--  CREATE TABLE orders (
--      id int PRIMARY KEY IDENTITY(101,1),
--      total int,
--      date DATE
--  );

--  CREATE table order_details (
--      id int PRIMARY KEY IDENTITY(1,1),
--      orderid int FOREIGN KEY REFERENCES orders(id),
--      productid int FOREIGN KEY REFERENCES products(id),
--      quantity int,
--      totalprice int,
--      discount int
--  );

--  INSERT into categories
--      (title,description)
--  VALUES
--      ('Electronics','All electronics'),
--      ('clothes','All clothes'),
--      ('footwares','All footwares'),
--      ('stationaries','All stationaries');

--  SELECT * from categories;

    -- insert into products
    --     (title,price,description,category,company)
    -- VALUES
    --  ('mobile',20000,'androidphone',1,'apple'),
    --  ('laptop',40000,'macbook',1,'apple'),
    --  ('notebook',80,'A4size',4,'classmates'),
    --  ('shoes',650,'casual',3,'marathon'),
    --  ('shirt',500,'formal',2,'bombaycompany');

--  SELECT * FROM products;

-- insert into orders
--     (total,date)
-- VALUES
--     (650,'2022-07-23'),
--     (2900,'2022-07-23'),
--     (500,'2022-07-23'),
--     (6050,'2022-07-23');

-- select * from orders;

-- insert into order_details
--     (orderid,productid,quantity,totalprice,discount)
-- VALUES
--     (101,11,3,500,5),
--     (102,13,4,900,7),
--     (102,12,1,100,12),
--     (103,13,6,5000,15);

-- select * from order_details;
