-- Asian Population
-- https://www.hackerrank.com/challenges/asian-population/problem
SELECT SUM(CITY.POPULATION)
FROM CITY, COUNTRY
WHERE CITY.CountryCode = COUNTRY.Code 
AND COUNTRY.CONTINENT = 'Asia';

-- African Cities
-- https://www.hackerrank.com/challenges/african-cities/problem
SELECT CITY.Name
FROM CITY, COUNTRY
WHERE CITY.CountryCode = COUNTRY.Code 
AND COUNTRY.CONTINENT = 'Africa';

-- Average Population of Each Continent
-- https://www.hackerrank.com/challenges/average-population-of-each-continent/problem
SELECT COUNTRY.CONTINENT, FLOOR(AVG(CITY.POPULATION))
FROM COUNTRY, CITY
WHERE COUNTRY.CODE = CITY.COUNTRYCODE
GROUP BY COUNTRY.CONTINENT;
