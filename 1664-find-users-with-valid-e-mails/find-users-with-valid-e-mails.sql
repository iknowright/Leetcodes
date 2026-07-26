/* Write your T-SQL query statement below */
SELECT user_id, name, mail
FROM Users
WHERE mail LIKE '[a-zA-Z]%@leetcode.com' COLLATE SQL_Latin1_General_CP1_CS_AS
  AND mail NOT LIKE '%[^a-zA-Z0-9_.-]%@leetcode.com';