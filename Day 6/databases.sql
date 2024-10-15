CREATE TABLE students (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    class INT
);

INSERT INTO students (id, name, class) VALUES
(1, 'Alice', 1),
(2, 'Bob', 2),
(3, 'Charlie', 3),
(4, 'David', 1),
(5, 'Eve', 3);

SELECT id, name, class FROM students WHERE class IN (1, 3);

SELECT id, name, class FROM students ORDER BY name ASC;
SELECT id, name, class FROM students ORDER BY name DESC;

SELECT id, name AS full_Name, class AS grade FROM students;

SELECT class, COUNT(id) FROM students GROUP BY class;
SELECT class, COUNT(id) AS count_of_students FROM students GROUP BY class;

SELECT class, COUNT(id) AS [count] FROM students GROUP BY class HAVING COUNT(id) < 5;

SELECT id, name, class FROM students;
SELECT TOP 5 id, name, class, FROM students;
SELECT id, name, class FROM students ORDER BY id OFFSET 5 ROWS FETCH NEXT 3 ROWS ONLY;
SELECT LEN('Hello');
SELECT name, LEN (name) as name_length FROM students;

SELECT COUNT(id) AS total_students FROM students;
SELECT SUM(class) AS total_students FROM students;
SELECT MIN(class) AS total_students FROM students;
SELECT MAX(class) AS total_students FROM students;
SELECT AVG(class) AS total_students FROM students;