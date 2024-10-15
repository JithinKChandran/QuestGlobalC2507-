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
    CONSTRAINT fk_std_id FOREIGN KEY (student_id) REFERENCES Students(student_id)
);


INSERT INTO Students (student_id, name) VALUES
(1, 'Alice'),
(2, 'Bob'),
(3, 'Charlie');


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
(2, 1, 102, 90, 2),
(3, 1, 103, 78, 3),
(4, 2, 101, 88, 1),
(5, 2, 102, 92, 2),
(6, 2, 103, 80, 3),
(7, 3, 101, 87, 1),
(8, 3, 102, 91, 2),
(9, 3, 103, 79, 3);