### **Normalization**

Normalization in Database Management Systems (DBMS) is a process used to organize a database into tables and columns to reduce redundancy and improve data integrity. The main goal is to eliminate undesirable characteristics like insertion, update, and deletion anomalies.

### **Redundancy**

Redundancy refers to the unnecessary duplication of data within a database. While some redundancy can be beneficial for data backup and recovery, excessive redundancy can lead to several issues.

### **Update Anomalies**

If data is duplicated, updating it in one place requires updating it in all other places where it exists. Missing an update in any location can lead to incorrect data being used.

### **Insertion Anomalies**

Redundancy can make it difficult to insert new data. For instance, if you need to add a new subject but don’t have any students enrolled in it yet, you might face issues inserting the subject due to dependencies on other tables.

### **Deletion Anomalies**

Deleting data can inadvertently remove important information. For example, deleting a student who is the only one enrolled in a particular subject might also remove the subject information.