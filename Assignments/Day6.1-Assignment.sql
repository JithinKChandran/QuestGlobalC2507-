CREATE TABLE courses (
    student_id INT PRIMARY KEY,
    course_id INT,
    course_name VARCHAR(100),
    course_fee INT
);

INSERT INTO courses (course_id, course_name, student_id, course_fee) VALUES
(1, 'Mathematics', 101, 500),
(1, 'Mathematics', 102, 500),
(2, 'Science', 103, 600),
(3, 'History', 104, 400),
(3, 'History', 105, 400);

SELECT course_name, COUNT(student_id) AS total_students
FROM courses
GROUP BY course_name;

SELECT course_name, SUM(course_fee) AS total_fees_collected
FROM courses
GROUP BY course_name;

SELECT course_name, COUNT(student_id) AS total_students
FROM courses
GROUP BY course_name
ORDER BY total_students DESC;