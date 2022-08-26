--                                         Assignment 5
-------------------------------Questions---------------------------------------------
-- Display first name and last name after converting the first letter of each name to upper case and the rest to lower case.
-- Display the first word in job title.
-- Display the length of first name for employees where last name contain character ‘b’ after 3rd position.
-- Display first name in upper case and email address in lower case for employees where the first name and email address are same irrespective of the case.
-- Display first name, salary, and round the salary to thousands.
-- Display employee ID and the date on which he ended his previous job.
-- Display first name and date of first salary of the employees.
-- Display first name and experience of the employees.
-- Display first name of employees who joined in 2001.
-- Display employees who joined in the current year.
-- Display the number of days between system date and 1st January 2011.
-- Display number of employees joined after 15th of the month.
-- Display third highest salary of employees.


-------------------------------Answers------------------------------------------------



--  use hr;

-- select concat(upper(SUBSTRING(first_name,1,1)),LOWER(SUBSTRING(first_name,2,len(first_name)))) as Fname,concat(upper(SUBSTRING(last_name,1,1)),LOWER(SUBSTRING(last_name,2,len(last_name)))) as Lname from employees;

--  select distinct  substring(JOB_TITLE,1,charindex(' ',JOB_TITLE)) as jt from jobs;

--  select len(first_name) as Fname_length from employees where last_name like '___%b%';

-- select UPPER(first_name) as Fname, lower(email) as email from employees;

-- select first_name,salary,ROUND(salary,1000) from employees;

-- select e.EMPLOYEE_ID,end_date from employees e,job_history j where e.EMPLOYEE_ID=j.EMPLOYEE_ID;

-----*******Fetching First salary date (AFTER ONE MONTH OR YEAR)************----------------
--  select e.EMPLOYEE_ID,hire_date,DATEADD(MONTH,1,HIRE_DATE) as Fsalary_date from employees e,job_history j where e.EMPLOYEE_ID=j.EMPLOYEE_ID;

--select first_name, dateDIFF( year, HIRE_DATE,getdate()) as experience(YEAR) from employees;

--  select first_name from employees where hire_date>('2001-12-31');

--select DISTINCT(DATEDIFF(DAY,'2001-01-01','2022-08-26')) AS EXPERIENCE FROM job_history;

 --select datediff(day,getdate(),'2011-01-2011') from employees;

--select count(*) as count_of_emp from employees where DAY(HIRE_DATE)>'15';

-- select max(salary) from employees where salary<(select max(salary) from employees where SALARY<(select max(SALARY) from employees));

