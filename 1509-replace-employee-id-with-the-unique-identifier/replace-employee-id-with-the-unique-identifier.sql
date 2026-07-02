/* Write your T-SQL query statement below */
SELECT uni.unique_id, [name]
FROM Employees
LEFT JOIN EmployeeUNI uni
ON Employees.id=uni.id;