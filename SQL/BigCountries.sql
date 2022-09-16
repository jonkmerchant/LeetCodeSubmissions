--Comments: This is an optimized script that beats ~77% of current submissions on LeetCode; the reason for this is that UNIONs of two statements compile
--more quickly in SQL than using OR in the WHERE clause

SELECT name, population, area
FROM World
WHERE (population >= 25000000)

UNION
SELECT name, population, area
FROM World
WHERE (area >= 3000000 )
