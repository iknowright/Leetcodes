/* Write your T-SQL query statement below */
SELECT results 
FROM (
    SELECT TOP 1 u.name AS results
    FROM Users u
    JOIN MovieRating mr 
        ON u.user_id = mr.user_id
    GROUP BY u.name
    ORDER BY COUNT(mr.movie_id) DESC, u.name ASC
) AS TopUser

UNION ALL

SELECT results 
FROM (
    SELECT TOP 1 m.title AS results
    FROM Movies m
    JOIN MovieRating mr 
        ON m.movie_id = mr.movie_id
    WHERE YEAR(mr.created_at) = 2020 
      AND MONTH(mr.created_at) = 2
    GROUP BY m.title
    ORDER BY AVG(CAST(mr.rating AS FLOAT)) DESC, m.title ASC
) AS TopMovie;