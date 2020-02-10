-- SELECT ... FROM
-- Selecting the names for all countries

SELECT name FROM country; --semicolon optional


-- Selecting the name and population of all countries
select name, population From Country --select only this to have just this part run

-- Selecting all columns from the city table
Select * From City

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
SELECT *
From city
Where district = 'Ohio'


-- Selecting countries that gained independence in the year 1776
Select *
From country
Where indepyear = 1776

-- Selecting countries not in Asia
Select *
From country
Where Continent !='Asia'

-- Selecting countries that do not have an independence year
Select *
From Country
Where indepyear IS NULL

-- Selecting countries that do have an independence year
Select *
From Country
Where indepyear Is not null


-- Selecting countries that have a population greater than 5 million
Select *
From Country
Where population > 5000000


-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000

-- Selecting country names on the continent North America or South America




-- SELECTING DATA w/arithmetic
-- Selecting the population, life expectancy, and population per area
--	note the use of the 'as' keyword



