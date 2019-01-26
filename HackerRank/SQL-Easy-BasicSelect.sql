-- Revising the Select Query
-- https://www.hackerrank.com/challenges/revising-the-select-query/problem
SELECT ID, NAME, COUNTRYCODE, DISTRICT, POPULATION
FROM CITY
WHERE COUNTRYCODE = 'USA' AND POPULATION > 100000;

-- Revising the Select Query II
-- https://www.hackerrank.com/challenges/revising-the-select-query-2/problem
SELECT NAME
FROM CITY
WHERE COUNTRYCODE = 'USA' AND POPULATION > 120000;

-- Select All
-- https://www.hackerrank.com/challenges/select-all-sql/problem
SELECT ID, NAME, COUNTRYCODE, DISTRICT, POPULATION
FROM CITY;

-- Select by ID
-- https://www.hackerrank.com/challenges/select-by-id/problem
SELECT ID, NAME, COUNTRYCODE, DISTRICT, POPULATION
FROM CITY
WHERE ID = 1661;

-- Japanese Cities' Attributes
-- https://www.hackerrank.com/challenges/japanese-cities-attributes/problem
SELECT ID, NAME, COUNTRYCODE, DISTRICT, POPULATION
FROM CITY
WHERE COUNTRYCODE = 'JPN';

-- Japanese Cities' Names
-- https://www.hackerrank.com/challenges/japanese-cities-name/problem
SELECT NAME
FROM CITY
WHERE COUNTRYCODE = 'JPN';

-- Weather Observation Station 1
-- https://www.hackerrank.com/challenges/weather-observation-station-1/problem
SELECT CITY, STATE
FROM STATION;

-- Weather Observation Station 3
-- https://www.hackerrank.com/challenges/weather-observation-station-3/problem
SELECT DISTINCT CITY
FROM STATION
WHERE MOD(ID, 2) = 0;

-- Weather Observation Station 4
-- https://www.hackerrank.com/challenges/weather-observation-station-4/problem
SELECT COUNT(CITY) - COUNT(DISTINCT CITY)
FROM STATION

-- Weather Observation Station 5
-- https://www.hackerrank.com/challenges/weather-observation-station-5/problem
-- Oracle
SELECT * 
FROM 
(
    SELECT CITY, LENGTH(CITY) length 
    FROM STATION 
    ORDER BY length ASC, CITY
) 
WHERE rownum = 1;

SELECT * 
FROM 
(
    SELECT CITY, LENGTH(CITY) length 
    FROM STATION 
    ORDER BY length DESC, CITY
) 
WHERE rownum = 1;

-- Weather Observation Station 6 
-- https://www.hackerrank.com/challenges/weather-observation-station-6/problem
SELECT DISTINCT CITY
FROM STATION
WHERE CITY LIKE 'A%' 
OR CITY LIKE 'E%' 
OR CITY LIKE 'I%' 
OR CITY LIKE 'O%' 
OR CITY LIKE 'U%';

-- Weather Observation Station 7
-- https://www.hackerrank.com/challenges/weather-observation-station-7/problem
SELECT DISTINCT CITY
FROM STATION
WHERE CITY LIKE '%a' 
OR CITY LIKE '%e' 
OR CITY LIKE '%i' 
OR CITY LIKE '%o' 
OR CITY LIKE '%u';

-- Weather Observation Station 8
-- https://www.hackerrank.com/challenges/weather-observation-station-8/problem
SELECT DISTINCT CITY
FROM STATION
WHERE 
(
    CITY LIKE '%a' 
    OR CITY LIKE '%e' 
    OR CITY LIKE '%i' 
    OR CITY LIKE '%o' 
    OR CITY LIKE '%u'
)
AND 
(
    CITY LIKE 'A%' 
    OR CITY LIKE 'E%' 
    OR CITY LIKE 'I%' 
    OR CITY LIKE 'O%' 
    OR CITY LIKE 'U%'
);

-- Weather Observation Station 9
-- https://www.hackerrank.com/challenges/weather-observation-station-9/problem
SELECT DISTINCT CITY
FROM STATION
WHERE NOT CITY LIKE 'A%' 
AND NOT CITY LIKE 'E%' 
AND NOT CITY LIKE 'I%' 
AND NOT CITY LIKE 'O%' 
AND NOT CITY LIKE 'U%';

-- Weather Observation Station 10
-- https://www.hackerrank.com/challenges/weather-observation-station-10/problem
SELECT DISTINCT CITY
FROM STATION
WHERE NOT CITY LIKE '%a' 
AND NOT CITY LIKE '%e' 
AND NOT CITY LIKE '%i' 
AND NOT CITY LIKE '%o' 
AND NOT CITY LIKE '%u';

-- Weather Observation Station 11
-- https://www.hackerrank.com/challenges/weather-observation-station-11/problem
SELECT DISTINCT CITY
FROM STATION
WHERE NOT
(
    CITY LIKE '%a' 
    OR CITY LIKE '%e' 
    OR CITY LIKE '%i' 
    OR CITY LIKE '%o' 
    OR CITY LIKE '%u'
)
OR NOT 
(
    CITY LIKE 'A%' 
    OR CITY LIKE 'E%' 
    OR CITY LIKE 'I%' 
    OR CITY LIKE 'O%' 
    OR CITY LIKE 'U%'
);

-- Weather Observation Station 12
-- https://www.hackerrank.com/challenges/weather-observation-station-12/problem
SELECT DISTINCT CITY
FROM STATION
WHERE NOT
(
    CITY LIKE '%a' 
    OR CITY LIKE '%e' 
    OR CITY LIKE '%i' 
    OR CITY LIKE '%o' 
    OR CITY LIKE '%u'
)
AND NOT 
(
    CITY LIKE 'A%' 
    OR CITY LIKE 'E%' 
    OR CITY LIKE 'I%' 
    OR CITY LIKE 'O%' 
    OR CITY LIKE 'U%'
);

-- Higher Than 75 Marks
-- https://www.hackerrank.com/challenges/more-than-75-marks/problem
SELECT Name
FROM STUDENTS
WHERE Marks > 75
ORDER BY RIGHT(Name, 3), ID ASC;

-- Employee Names
-- https://www.hackerrank.com/challenges/name-of-employees/problem
SELECT name
FROM Employee
ORDER BY name;

-- Employee Salaries
-- https://www.hackerrank.com/challenges/salary-of-employees/problem
SELECT name
FROM Employee
WHERE months < 10
AND salary > 2000
ORDER BY employee_id;
