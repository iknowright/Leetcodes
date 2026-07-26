/* Write your T-SQL query statement below */
WITH FirstLogin AS (
    SELECT 
        player_id, 
        MIN(event_date) AS first_date
    FROM Activity
    GROUP BY player_id
)
SELECT 
    ROUND(COUNT(a.player_id) * 1.0 / COUNT(f.player_id), 2) AS fraction
FROM FirstLogin f
LEFT JOIN Activity a 
    ON f.player_id = a.player_id 
   AND a.event_date = DATEADD(day, 1, f.first_date);