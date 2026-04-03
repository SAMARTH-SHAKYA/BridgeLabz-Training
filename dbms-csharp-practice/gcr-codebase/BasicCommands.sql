
--- Creating a database ---
CREATE DATABASE Training;


--- Using a database ---
USE Training;


---Data defination commmands---

CREATE TABLE Students(
	ID INT PRIMARY KEY,
	Name VARCHAR(100)
);

ALTER TABLE Students ADD Age INT;

DROP TABLE Students;


---Data manipulation language--

INSERT INTO Students (ID, Name, Age) VALUES (1, 'Arjun', 20);

UPDATE Students SET Age = 21 WHERE ID = 1;

DELETE FROM Students WHERE ID = 1;


---Data query language----

INSERT INTO Students (ID, Name, Age) VALUES (1, 'Arjun', 20);

INSERT INTO Students (ID, Name, Age) VALUES (2, 'Priya', 21);

INSERT INTO Students (ID, Name, Age) VALUES (3, 'Rahul', 19);

INSERT INTO Students (ID, Name, Age) VALUES (4, 'Sneha', 22);

INSERT INTO Students (ID, Name, Age) VALUES (5, 'Karan', 20);

SELECT * FROM Students;

SELECT Name, Age FROM Students WHERE Age > 18; 


---Data control language---

GRANT SELECT ON Students TO user_name;

REVOKE SELECT ON Students FROM user_name;


---Transaction control lanaguage----

BEGIN;
UPDATE Students SET Age = 25 WHERE ID = 2;
SAVEPOINT sp1;
UPDATE Students SET Age = 30 WHERE ID = 3;
ROLLBACK TO sp1;
COMMIT;



--- Creating ann another table for joins operations ----

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    StudentID INT,
    CourseName VARCHAR(50),
    Marks INT,
    FOREIGN KEY (StudentID) REFERENCES Students(ID)
);


INSERT INTO Courses (CourseID, StudentID, CourseName, Marks) 
VALUES (101, 1, 'Math', 85);

INSERT INTO Courses (CourseID, StudentID, CourseName, Marks) 
VALUES (102, 2, 'Science', 90);

INSERT INTO Courses (CourseID, StudentID, CourseName, Marks) 
VALUES (103, 3, 'English', 78);

INSERT INTO Courses (CourseID, StudentID, CourseName, Marks) 
VALUES (104, 1, 'Computer', 95);

SELECT * FROM Courses;



--- Inner join ---
SELECT S.Name, C.CourseName, C.Marks
FROM Students S
INNER JOIN Courses C
ON S.ID = C.StudentID;


---Left outer join---
SELECT S.Name, C.CourseName, C.Marks
FROM Students S
LEFT JOIN Courses C
ON S.ID = C.StudentID;


---Right outer join---
SELECT S.Name, C.CourseName, C.Marks
FROM Students S
RIGHT JOIN Courses C
ON S.ID = C.StudentID;


---Full outer join--
SELECT S.Name, C.CourseName, C.Marks
FROM Students S
FULL OUTER JOIN Courses C
ON S.ID = C.StudentID;


---Cross join---
SELECT S.Name, C.CourseName
FROM Students S
CROSS JOIN Courses C;


---Self Join---
SELECT A.Name AS Student1, B.Name AS Student2, A.Age
FROM Students A
JOIN Students B
ON A.Age = B.Age AND A.ID <> B.ID;


