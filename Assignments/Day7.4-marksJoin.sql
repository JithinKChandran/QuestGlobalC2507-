CREATE TABLE Students (
    student_id INT PRIMARY KEY,
    name VARCHAR(100) NOT NULL
);

CREATE TABLE Subjects (
    sub_code INT PRIMARY KEY,
    sub_name VARCHAR(100) NOT NULL,
    UNIQUE (sub_name)
);

CREATE TABLE Exams (
    exam_id INT PRIMARY KEY,
    min_mark INT NOT NULL,
    max_mark INT NOT NULL
);

CREATE TABLE Marks (
    mark_id INT PRIMARY KEY,
    exam_id INT,
    sub_code INT,
    mark INT NOT NULL,
    student_id INT,
    
    CONSTRAINT fk_exm_id FOREIGN KEY (exam_id) REFERENCES Exams(exam_id),
    CONSTRAINT fk_std_id FOREIGN KEY (student_id) REFERENCES Students(student_id),
    CONSTRAINT fk_sub_id FOREIGN key (sub_code) REFERENCES Subjects(sub_code)
);


INSERT INTO Students (student_id, name) VALUES
(1, 'Alice Johnson'),
(2, 'Bob Smith'),
(3, 'Charlie Brown');


INSERT INTO Subjects (sub_code, sub_name) VALUES
(101, 'Mathematics'),
(102, 'Physics'),
(103, 'Chemistry');


INSERT INTO Exams (exam_id, min_mark, max_mark) VALUES
(1, 0, 100),
(2, 0, 100),
(3, 0, 100);


INSERT INTO Marks (mark_id, exam_id, sub_code, mark, student_id) VALUES
(1, 1, 101, 85, 1),
(2, 1, 102, 90, 1),
(3, 1, 103, 78, 1),
(4, 2, 101, 88, 2),
(5, 2, 102, 76, 2),
(6, 2, 103, 89, 2),
(7, 3, 101, 92, 3),
(8, 3, 102, 81, 3),
(9, 3, 103, 85, 3);

SELECT 
    Students.student_id,
    Students.name,
    Subjects.sub_code,
    Subjects.sub_name,
    Exams.exam_id,
    Exams.min_mark,
    Exams.max_mark,
    Marks.mark_id,
    Marks.mark
FROM 
    Marks
INNER JOIN Students ON Marks.student_id = Students.student_id
INNER JOIN Subjects ON Marks.sub_code = Subjects.sub_code
INNER JOIN Exams ON Marks.exam_id = Exams.exam_id;