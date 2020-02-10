-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in millions of US Dollars
--   The value immediately after the problem statement is the expected number of rows that should be returned by the query.

-- 1. The name and population of all cities in Ontario, Canada (27 rows)
SELECT Name, Population
From city
Where district = 'Ontario'
-- 2. The name and population of all cities in Montana (1 row)
SELECT  Name, Population
From City
Where district = 'Montana'
-- 3. The name, form of government, and head of state of all countries in Europe (46 rows)
SELECT Name, governmentform, headofstate
From Country
Where continent = 'Europe'
-- 4. The name, population, surface area, and average life expectancy of all countries in Asia (51 rows)
SELECT name, population, surfacearea, lifeexpectancy
From Country
Where continent = 'Asia'
-- 5. The name, country code, and population of all cities with a population greater than 8 million people (10 rows)
Select Name, population, countrycode
From City
Where population > 8000000
-- 6. The name, country code, and population of all cities with a population less than one thousand people (11 rows)
Select Name, population, countrycode
From City
Where population <1000
-- 7. The name, continent, and GNP of all countries with a GNP greater than one trillion dollars (6 rows)
Select Name, Continent, GNP
From Country
Where (gnpold > 1000000)
-- 8. The name, continent, population, GNP, and average life expectancy of all countries with an average life expectancy greater than 80 years (5 rows)
SELECT Name, Continent, Population, GNP, lifeexpectancy
FROM Country
Where lifeexpectancy>80
-- 9. The name and population of all cities in the USA with a population of greater than 1 million people (9 rows)
SELECT Name, Population
FROM City

Where countrycode = 'USA' AND population > 1000000

-- 10. The name and population of all cities in China with a population of greater than 1 million people (35 rows)
SELECT Name, population
From City
Where countrycode = 'CHN' AND population >1000000

-- 11. The name and region of all countries in North or South America (51 rows)
SELECT name, region
From Country
Where continent LIKE '%america'
-- 12. The name, continent, and head of state of all countries whose form of government is a monarchy (43 rows)
SELECT name, continent, headofstate
FROM country
WHERE governmentform LIKE '%monarchy%'
-- 13. The name of all cities in the USA with a population between 1 million and 2 million people (6 rows) 
SELECT name
FROM City
WHERE countrycode='USA' AND (population>1000000) AND (population <2000000)
-- 14. The name and region of all countries in North or South America except for countries in the Caribbean (27 rows)
SELECT name, region
FROM Country
Where Continent LIKE '%america'  AND region !='Caribbean'
-- 15. The name, population, and GNP of all countries with a GNP greater than $1 trillion dollars and a population of less than 100 million people (4 rows)
SELECT name, population, gnp
FROM Country
WHERE (population < 100000000) AND (gnp >1000000)
-- 16. The name and population of all cities in Texas that have a population of greater than 1 million people (3 rows)
SELECT name, population
FROM City
Where District = 'Texas' AND population >1000000
-- 17. The name and average life expectancy of all countries on the continent of Oceania (28 rows)
SELECT name, lifeexpectancy
FROM Country
WHERE continent = 'Oceania'
-- 18. The name and average life expectancy of all countries on the continent of Oceania for which an average life expectancy has been provided (i.e. not equal to null) (20 rows)
SELECT name, lifeexpectancy
FROM Country
Where  Continent = 'Oceania' AND lifeexpectancy IS NOT NULL
-- 19. The name of all countries on the continent of Oceania for which an average life expectancy has not been provided (i.e. equal to null) (8 rows)
SELECT name
FROM Country
WHERE continent = 'Oceania' AND lifeexpectancy IS NULL
-- 20. The name, continent, GNP, and average life expectancy of all countries that have an average life expectancy of at least 70 years and a GNP between $1 million and $100 million dollars (3 rows)
SELECT Name, continent, gnp, lifeexpectancy
FROM Country
WHERE lifeexpectancy >=70 AND gnp >= 1 AND gnp <=100

-- 21. The per capita GNP (i.e. GNP divided by population) in US Dollars of all countries in Europe (46 rows)
SELECT gnp/population
FROM Country
Where continent = 'Europe'
-- 22. The number of years since independence for all countries that have a year of independence (192 rows)
SELECT 2020-indepyear
FROM Country
WHERE indepyear IS NOT NULL