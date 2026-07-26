/* Write your T-SQL query statement below */
WITH FirstOrders AS (
    SELECT 
        order_date,
        customer_pref_delivery_date,
        ROW_NUMBER() OVER (PARTITION BY customer_id ORDER BY order_date ASC) AS rn
    FROM Delivery
)
SELECT 
    ROUND(
        SUM(CASE WHEN order_date = customer_pref_delivery_date THEN 100.0 ELSE 0.0 END) / COUNT(*), 
        2
    ) AS immediate_percentage
FROM FirstOrders
WHERE rn = 1;