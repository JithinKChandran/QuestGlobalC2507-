

**SQL Server Data Types**

SQL Server offers a diverse range of data types to accommodate various data requirements. Here's a breakdown of common categories:

**Numeric Data Types**

* **Exact Numerics:**  
  * bit: Stores binary values (0 or 1).  
  * tinyint: Stores integer values from 0 to 255\.  
  * smallint: Stores integer values from \-32,768 to 32,767.  
  * int: Stores integer values from \-2,147,483,648 to 2,147,483,647.  
  * bigint: Stores integer values from \-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.  
  * decimal, numeric: Stores precise decimal numbers with a specified precision and scale.  
  * money, smallmoney: Stores monetary values with a fixed precision and scale.  
* **Approximate Numerics:**  
  * float: Stores approximate floating-point numbers with varying precision.  
  * real: Stores approximate floating-point numbers with a fixed precision.

**Character and String Data Types**

* **Non-Unicode:**  
  * char: Stores fixed-length character data (padded with spaces if shorter).  
  * varchar: Stores variable-length character data.  
  * text: Stores large variable-length character data.  
* **Unicode:**  
  * nchar: Stores fixed-length Unicode character data (padded with spaces if shorter).  
  * nvarchar: Stores variable-length Unicode character data.  
  * ntext: Stores large variable-length Unicode character data.

**Date and Time Data Types**

* date: Stores a date value (year, month, day).  
* time: Stores a time value (hour, minute, second, millisecond).  
* datetime: Stores a date and time value with a precision of 3.3 milliseconds.  
* smalldatetime: Stores a date and time value with a precision of 1 minute.  
* datetime2: Stores a date and time value with a precision up to 7.3 nanoseconds.  
* datetimeoffset: Stores a date and time value with a time zone offset.

**Binary Data Types**

* binary: Stores fixed-length binary data.  
* varbinary: Stores variable-length binary data.  
* image: Stores large variable-length binary data.

**Other Data Types**

* xml: Stores XML data.  
* uniqueidentifier: Stores a globally unique identifier (GUID).  
* sql\_variant: Stores data of any data type.

**Difference Between nchar and nvarchar**

Both nchar and nvarchar are used to store Unicode character data, but they have key differences:

* **Storage:**  
  * nchar: Fixed-length, uses 2 bytes per character, padded with spaces.  
  * nvarchar: Variable-length, uses 2 bytes per character, no padding.  
* **Usage:**  
  * nchar: Use when sizes of column data entries are consistent (e.g., country codes).  
  * nvarchar: Use when sizes of column data entries vary considerably (e.g., names, descriptions).

**Example**

SQL

`CREATE TABLE ExampleNChar (`  
    `Name nchar(10)`  
`);`

`INSERT INTO ExampleNChar (Name) VALUES ('John');`  
`-- 'John' will be stored as 'John      ' (padded with spaces)`

`CREATE TABLE ExampleNVarChar (`  
    `Name nvarchar(50)`  
`);`

`INSERT INTO ExampleNVarChar (Name) VALUES ('John');`  
`-- 'John' will be stored as 'John' (no padding)`