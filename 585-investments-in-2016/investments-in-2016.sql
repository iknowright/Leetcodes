/* Write your T-SQL query statement below */
WITH PolicyCounts AS (
    SELECT 
        tiv_2016,
        COUNT(*) OVER (PARTITION BY tiv_2015) AS tiv_2015_cnt,
        COUNT(*) OVER (PARTITION BY lat, lon) AS loc_cnt
    FROM Insurance
)
SELECT 
    ROUND(SUM(tiv_2016), 2) AS tiv_2016
FROM PolicyCounts
WHERE tiv_2015_cnt > 1 AND loc_cnt = 1;