 --                       Assignment 1
-------------------------------Questions---------------------------------------------
--     create 'student_db' database
--     create following tables in database with proper data types
--     student: id (PK), name, address, phone, email, age, schoolId (FK)
--     school: id (PK), name, address, principal, phone
--     create relationship as shown in the table schema
--     add some dummy data

-------------------------------Answers------------------------------------------------

-- CREATE DATABASE student_db;

-- use student_db;

-- CREATE TABLE school (
--     id int PRIMARY KEY IDENTITY(1,1),
--     name VARCHAR(20),
--     address varchar(20),
--     principal varchar(20),
--     phone NUMERIC(10,0)
-- );

-- CREATE TABLE student (
--     id int PRIMARY KEY IDENTITY(1,1),
--     name varchar(20),
--     address varchar(20),
--     phone NUMERIC(10,0),
--     email varchar(20),
--     age int,
--     schoolid int FOREIGN KEY REFERENCES school (id)
-- );

-- INSERT into school
--     (name,address,principal,phone)
-- VALUES
--     ('KBPV','satara','Patil_S_S',9999887766),
--     ('SGM','Karad','Jadhav_S_p',7777887766),
--     ('Modern','Pune','Yadav_P_S',8888887766);

-- INSERT into student 
--     (name,address,phone,email,age,schoolid)
-- VALUES
--     ('Shivam','pune',9999777765,'shivam@gmail.com',23,2),
--     ('shubham','satara',8888999965,'shubham@gmail.com',24,1),
--     ('Rahul','karad',7766885576,'rahul@gmail.com',22,2),
--     ('Raj','sangali',7788665544,'raj@gmail.com',22,2);

-- SELECT * from student;

-- SELECT * from school;