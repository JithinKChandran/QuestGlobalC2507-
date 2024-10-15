## 

**Database Management System (DBMS) Commands and Their Uses**

### **Data Definition Language (DDL) Commands**

* **Purpose:** Used to define the database structure, including tables, columns, data types, and relationships.  
* **Commands:**  
  * **CREATE TABLE:** Creates a new table with specified columns and data types.  
  * **ALTER TABLE:** Modifies an existing table by adding, dropping, or modifying columns.  
  * **DROP TABLE:** Deletes an existing table and its data.  
  * **CREATE INDEX:** Creates an index on a column to improve query performance.  
  * **DROP INDEX:** Deletes an existing index.  
  * **CREATE VIEW:** Creates a virtual table based on the result of a SELECT query.  
  * **DROP VIEW:** Deletes an existing view.

### **Data Manipulation Language (DML) Commands**

* **Purpose:** Used to manipulate data within the database by inserting, updating, and deleting records.  
* **Commands:**  
  * **INSERT INTO:** Inserts new rows into a table.  
  * **UPDATE:** Modifies existing rows in a table.  
  * **DELETE:** Removes rows from a table.  
  * **TRUNCATE TABLE:** Deletes all rows from a table, but retains the table structure.

### **Data Control Language (DCL) Commands**

* **Purpose:** Used to control access to the database and manage user privileges.  
* **Commands:**  
  * **GRANT:** Grants privileges to a user or role.  
  * **REVOKE:** Revokes privileges from a user or role.  
  * **COMMIT:** Saves changes made to the database.  
  * **ROLLBACK:** Undoes changes made to the database.

### **Transaction Control Language (TCL) Commands**

* **Purpose:** Used to manage transactions and ensure data integrity.  
* **Commands:**  
  * **COMMIT:** Saves changes made to the database within a transaction.  
  * **ROLLBACK:** Undoes changes made to the database within a transaction.  
  * **SAVEPOINT:** Sets a savepoint within a transaction.  
  * **ROLLBACK TO SAVEPOINT:** Rolls back the transaction to a specified savepoint.

### **Data Query Language (DQL) Commands**

* **Purpose:** Used to retrieve data from the database.  
* **Commands:**  
  * **SELECT:** Retrieves data from one or more tables.  
  * **WHERE:** Filters the results of a SELECT query based on specified conditions.  
  * **FROM:** Specifies the tables to be queried.  
  * **JOIN:** Combines rows from multiple tables based on related columns.  
  * **GROUP BY:** Groups rows based on a specified column or expression.  
  * **HAVING:** Filters the results of a GROUP BY query based on specified conditions.  
  * **ORDER BY:** Sorts the results of a query based on specified columns.  
  * **DISTINCT:** Removes duplicate rows from the result set.  
  * **UNION:** Combines the result sets of two or more SELECT queries.  
  * **INTERSECT:** Returns rows that are common to the result sets of two or more SELECT queries.  
  * **EXCEPT:** Returns rows that are in the result set of the first SELECT query but not in the result set of the second SELECT query.

### **Aggregate Functions**

* **COUNT:** Counts the number of rows.  
* **SUM:** Calculates the sum of values.  
* **AVG:** Calculates the average of values.  
* **MIN:** Returns the minimum value.  
* **MAX:** Returns the maximum value.

### **Types of JOIN**

* **INNER JOIN:** Returns rows that have matching values in both tables.  
* **LEFT OUTER JOIN:** Returns all rows from the left table, even if there are no matches in the right table.    
* **RIGHT OUTER JOIN:** Returns all rows from the right table, even if there are no matches in the left table.    
* **FULL OUTER JOIN:** Returns all rows when there is a match in either left or right table.    
* **SELF JOIN:** Joins a table to itself based on a specific condition.

### **DROP**

* **Purpose:** Removes a database object (e.g., table, index, view) from the database.  
* **Syntax:**  
  * DROP TABLE table\_name;  
  * DROP INDEX index\_name;  
  * DROP VIEW view\_name;

### **CREATE**

* **Purpose:** Creates a new database object (e.g., table, index, view).  
* **Syntax:**  
  * CREATE TABLE table\_name (column\_name data\_type, ...);  
  * CREATE INDEX index\_name ON table\_name (column\_name);  
  * CREATE VIEW view\_name AS SELECT ...;

### **ALTER**

* **Purpose:** Modifies an existing database object (e.g., table, index, view).  
* **Syntax:**  
  * ALTER TABLE table\_name ADD COLUMN column\_name data\_type;  
  * ALTER TABLE table\_name DROP COLUMN column\_name;  
  * ALTER TABLE table\_name    MODIFY COLUMN column\_name data\_type;

### **HAVING**

* **Purpose:** Filters the results of a GROUP BY query based on specified conditions.  
* **Syntax:**  
  * SELECT ... FROM ... GROUP BY ... HAVING condition;

### **GROUP BY**

* **Purpose:** Groups rows based on a specified column or expression.  
* **Syntax:**  
  * SELECT ... FROM ... GROUP BY column\_name;

### **VIEW**

* **Purpose:** Creates a virtual table based on the result of a SELECT query.  
* **Syntax:**  
  * CREATE VIEW view\_name AS SELECT ...;

### **SELECT**

* **Purpose:** Retrieves data from the database.  
* **Syntax:**  
  * SELECT column\_name FROM table\_name;

### **WHERE**

* **Purpose:** Filters the results of a SELECT query based on specified conditions.  
* **Syntax:**  
  * SELECT ... FROM ... WHERE condition;

### **ORDER BY**

* **Purpose:** Sorts the results of a query based on specified columns.  
* **Syntax:**  
  * SELECT ... FROM ... ORDER BY column\_name ASC|DESC;

### **INSERT INTO**

* **Purpose:** Inserts new rows into a table.  
* **Syntax:**  
  * INSERT INTO table\_name (column\_name, ...) VALUES (value1, ...);

### **UPDATE**

* **Purpose:** Modifies existing rows in a table.  
* **Syntax:**  
  * UPDATE table\_name SET column\_name \= value WHERE condition;

### **DELETE**

* **Purpose:** Removes rows from a table.  
* **Syntax:**  
  * DELETE FROM table\_name WHERE condition;

### **TRUNCATE**

* **Purpose:** Deletes all rows from a table, but retains the table structure.  
* **Syntax:**  
  * TRUNCATE TABLE table\_name;

### **FUNCTIONS**

* **Purpose:** Performs calculations or operations on data.  
* **Examples:**  
  * **Mathematical functions:** SUM, AVG, MIN, MAX, COUNT, etc.  
  * **String functions:** LENGTH, CONCAT, UPPER, LOWER, etc.  
  * **Date and time functions:** NOW, DATE, TIME, etc.

### **DISTINCT**

* **Purpose:** Removes duplicate rows from the result set.  
* **Syntax:**  
  * SELECT DISTINCT column\_name FROM table\_name;

### **CREATE INDEX**

* **Purpose:** Creates an index on a column to improve query performance.  
* **Syntax:**  
  * CREATE INDEX index\_name ON table\_name (column\_name);

### **TRIGGER**

* **Purpose:** Executes a specified SQL statement when a certain event occurs (e.g., INSERT, UPDATE, DELETE).  
* **Syntax:**  
  * CREATE TRIGGER trigger\_name AFTER|BEFORE event ON table\_name FOR EACH ROW BEGIN ... END;

### **TRANSACTION**

* **Purpose:** A group of SQL statements that are treated as a single unit.  
* **Commands:**  
  * BEGIN TRANSACTION  
  * COMMIT  
  * ROLLBACK

### **ROLLBACK**

* **Purpose:** Undoes changes made to the database within a transaction.  
* **Syntax:**  
  * ROLLBACK;

### **COMMIT**

* **Purpose:** Saves changes made to the database within a transaction.  
* **Syntax:**  
  * COMMIT;

### **CHECK**

* **Purpose:** Defines a constraint that ensures data integrity by limiting the values that can be stored in a column.  
* **Syntax:**  
  * CREATE TABLE table\_name (column\_name data\_type CHECK (condition), ...);