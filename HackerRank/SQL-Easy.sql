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
