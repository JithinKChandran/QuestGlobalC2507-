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