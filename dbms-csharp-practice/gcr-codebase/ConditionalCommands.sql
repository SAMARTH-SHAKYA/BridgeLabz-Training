-- Basic SELECT with WHERE

-- Get all employees from IT department
SELECT * FROM Employees
WHERE Department = 'IT';

-- Get employees with salary greater than 50000
SELECT * FROM Employees
WHERE Salary > 50000;

-- Get employees with salary between 40000 and 80000
SELECT * FROM Employees
WHERE Salary BETWEEN 40000 AND 80000;

-- Get employees whose name starts with S
SELECT * FROM Employees
WHERE Name LIKE 'S%';

-- Get employees from IT and salary > 50000
SELECT * FROM Employees
WHERE Department = 'IT' AND Salary > 50000;

------------------------------------------------------------

-- Aggregate Functions

-- Total employees
SELECT COUNT(*) AS TotalEmployees
FROM Employees;

-- Maximum salary
SELECT MAX(Salary) AS MaxSalary
FROM Employees;

-- Minimum salary
SELECT MIN(Salary) AS MinSalary
FROM Employees;

-- Average salary
SELECT AVG(Salary) AS AvgSalary
FROM Employees;

-- Total salary
SELECT SUM(Salary) AS TotalSalary
FROM Employees;

------------------------------------------------------------

-- GROUP BY Examples

-- Count employees in each department
SELECT Department, COUNT(*) AS TotalEmployees
FROM Employees
GROUP BY Department;

-- Average salary per department
SELECT Department, AVG(Salary) AS AvgSalary
FROM Employees
GROUP BY Department;

-- Total salary per department
SELECT Department, SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY Department;

-- Count employees by gender
SELECT Gender, COUNT(*) AS TotalEmployees
FROM Employees
GROUP BY Gender;

------------------------------------------------------------

-- GROUP BY with WHERE

-- Average salary of IT department
SELECT Department, AVG(Salary) AS AvgSalary
FROM Employees
WHERE Department = 'IT'
GROUP BY Department;

------------------------------------------------------------

-- GROUP BY with HAVING

-- Departments where average salary > 50000
SELECT Department, AVG(Salary) AS AvgSalary
FROM Employees
GROUP BY Department
HAVING AVG(Salary) > 50000;

-- Departments having more than 2 employees
SELECT Department, COUNT(*) AS TotalEmployees
FROM Employees
GROUP BY Department
HAVING COUNT(*) > 2;

------------------------------------------------------------

-- ORDER BY Examples

-- Order employees by salary ascending
SELECT * FROM Employees
ORDER BY Salary ASC;

-- Order employees by salary descending
SELECT * FROM Employees
ORDER BY Salary DESC;

-- Order by department then salary
SELECT * FROM Employees
ORDER BY Department ASC, Salary DESC;