/* Write your T-SQL query statement below */
WITH RunningWeight AS (
    SELECT person_name,turn,
        SUM(weight) OVER (ORDER BY turn ASC) AS total_weight
    FROM Queue
)
SELECT TOP 1 person_name
FROM RunningWeight
WHERE total_weight <= 1000
ORDER BY turn DESC;