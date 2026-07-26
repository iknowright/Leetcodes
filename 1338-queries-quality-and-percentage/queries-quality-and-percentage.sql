/* Write your T-SQL query statement below */
SELECT query_name,
ROUND(AVG(CAST(rating AS DECIMAL(10, 2)) / position), 2) AS quality,
ROUND(AVG(CASE WHEN rating < 3 THEN 100.0 ELSE 0 END), 2) AS poor_query_percentage
FROM Queries
WHERE query_name IS NOT NULL
GROUP BY query_name;