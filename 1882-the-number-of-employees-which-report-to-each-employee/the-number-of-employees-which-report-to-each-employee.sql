/* Write your T-SQL query statement below */
SELECT m.employee_id, m.name,
    COUNT(e.employee_id) AS reports_count,
    ROUND(AVG(CAST(e.age AS FLOAT)), 0) AS average_age
FROM Employees m
JOIN Employees e ON m.employee_id = e.reports_to
GROUP BY m.employee_id, m.name
ORDER BY m.employee_id;