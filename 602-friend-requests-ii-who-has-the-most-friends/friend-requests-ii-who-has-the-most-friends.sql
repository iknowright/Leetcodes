/* Write your T-SQL query statement below */
SELECT TOP 1 
    id, 
    COUNT(id) AS num
FROM (
    SELECT requester_id AS id FROM RequestAccepted
    UNION ALL
    SELECT accepter_id AS id FROM RequestAccepted
) AS friends
GROUP BY id
ORDER BY num DESC;