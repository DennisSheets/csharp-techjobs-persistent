-- Part 1
-- https://thispointer.com/mysql-get-column-names-and-datatypes-of-a-table/

SELECT COLUMN_NAME , DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE 
    TABLE_SCHEMA = Database()
AND TABLE_NAME = 'jobs' ;


--Part 2




--Part 3

