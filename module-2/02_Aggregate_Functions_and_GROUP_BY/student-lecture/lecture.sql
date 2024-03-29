-- ORDERING RESULTS

-- Populations of all countries in descending order
Select name, population
FROM Country
ORDER BY population DESC
--Names of countries and continents in ascending order
SELECT name, continent
FROM country
Order By continent, name
-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.
SELECT TOP 10 name, lifeexpectancy
FROM Country
ORDER BY lifeexpectancy DESC

-- CONCATENATING OUTPUTS

-- The name & state of all cities in California, Oregon, or Washington.
-- "city, state", sorted by state then city
SELECT name + ',' + district AS 'CityState'
FROM city
WHERE district IN ('California', 'Oregon', 'Washington')
ORDER BY district, name


-- Can you do it another way?


-- AGGREGATE FUNCTIONS
--Total population in Asia
SELECT SUM(population)
FROM Country
WHERE Continent = 'Asia'

SELECT SUM(CAST(population AS BigInt)) 
FROM Country 
WHERE continent = 'Asia'

--AVG pop in Asia

SELECT AVG (CAST(population AS BigInt)) 
FROM country
Where Continent = 'Asia'

-- Average Life Expectancy in the World
SELECT AVG(lifeexpectency)
FROM Country


-- Total population in Ohio
SELECT SUM (population)
FROM City
WHERE district = 'Ohio'
-- The surface area of the smallest country in the world
SELECT MIN(surfacearea)
FROM Country
-- The 10 largest countries in the world by length of name
SELECT TOP 10 name, LEN(name) AS NameLength
FROM country
ORDER BY NameLength DESC
-- The number of countries who declared independence in 1991
SELECT COUNT(*)
From Country
WHERE indepyear = 1991
-- GROUP BY
-- Count the number of countries where each language is spoken, ordered from most countries to least
SELECT language, COUNT(countrycode) AS CountryCount
From countrylanguage
GROUP BY language
ORDER BY CountryCount DESC
-- Average life expectancy of each continent ordered from highest to lowest


-- Exclude Antarctica from consideration for average life expectancy

-- Sum of the population of cities in each state in the USA ordered by state name

-- The average population of cities in each state in the USA ordered by state name

-- SUBQUERIES
-- Find the names of cities under a given government leader

-- Find the names of cities whose country they belong to has not declared independence yet

-- Select those countries with lower than average life expectancy

-- Additional samples
-- You may alias column and table names to be more descriptive

-- Alias can also be used to create shorthand references, such as "c" for city and "co" for country.

-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)

-- While you can use TOP to limit the number of results returned by a query,
-- in SQL Server it is recommended to use OFFSET and FETCH if you want to get
-- "pages" of results. For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)

-- Most database platforms provide string functions that can be useful for working with string data. In addition to string functions, string concatenation is also usually supported, which allows us to build complete sentences if necessary.

-- Aggregate functions provide the ability to COUNT, SUM, and AVG, as well as determine MIN and MAX. Only returns a single row of value(s) unless used with GROUP BY.
-- Counts the number of rows in the city table

-- Also counts the number of rows in the city table

-- Gets the SUM of the population field in the city table, as well as
-- the AVG population, and a COUNT of the total number of rows.

-- Gets the MIN population and the MAX population from the city table.

-- Using a GROUP BY with aggregate functions allows us to summarize information for a specific column. For instance, we are able to determine the MIN and MAX population for each countrycode in the city table.
