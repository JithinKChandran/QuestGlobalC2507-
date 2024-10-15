-- create
DROP TABLE users;
CREATE TABLE users(
    id BIGINT IDENTITY(1,1) NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    username VARCHAR(25) NOT NULL,
    email VARCHAR(100) NOT NULL,
    dob DATETIME,
    phone_number VARCHAR(20),
    password_hash VARCHAR(250),
    about TEXT
);

-- insert
INSERT INTO EMPLOYEE(empId,name,dept) VALUES (1, 'Clark', 'Sales');
INSERT INTO EMPLOYEE(empId,name,dept) VALUES (2, 'Dave', 'Accounting');
INSERT INTO EMPLOYEE(empId,name,dept) VALUES (3, 'Ava', 'Sales');

-- fetch 
ALTER TABLE users
ADD CONSTRAINT PK_user_id PRIMARY KEY (id)

ALTER TABLE users
ADD CONSTRAINT UQ_user_username UNIQUE (username)

ALTER TABLE users
ADD CONSTRAINT UQ_user_email UNIQUE (email)

CREATE INDEX IX_ users_phone
ON users (phone_number)

ALTER TABLE   users
ADD CONSTRAINT CHK_users_phone CHECK (len(phone_number) BETWEEN 7 AND 20)

ALTER TABLE users
ADD CONSTRAINT CHK_users_dob CHECK (dob < GETDATE())