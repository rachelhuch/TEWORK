-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT title
FROM film
JOIN film_actor ON film_actor.film_id = film.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.first_name = 'Nick' AND actor.last_name ='Stallone'
-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT title
FROM film
JOIN film_actor ON film_actor.film_id = film.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE actor.first_name = 'Rita' AND actor.last_name ='Reynolds'


-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT title
FROM film
JOIN film_actor ON film_actor.film_id = film.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE  actor.last_name ='Dean'

-- 4. All of the the ‘Documentary’ films
-- (68 rows)
Select title
From film
Join film_category ON film_category.film_id=film.film_id 
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Documentary'


-- 5. All of the ‘Comedy’ films
-- (58 rows)
Select title
From film
Join film_category ON film_category.film_id=film.film_id 
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
Select title
From film
Join film_category ON film_category.film_id=film.film_id 
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Children' AND film.rating='G'


-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
Select title
From film
Join film_category ON film_category.film_id=film.film_id 
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Family' AND film.rating='G' AND film.length < 120
-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT title
FROM film
JOIN film_actor ON film_actor.film_id = film.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE  actor.first_name = 'Matthew' AND actor.last_name ='Leigh' AND film.rating = 'G'

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
Select title
From film
Join film_category ON film_category.film_id=film.film_id 
JOIN category ON category.category_id = film_category.category_id
WHERE category.name = 'Sci-Fi' AND film.release_year = 2006

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
Select title
From film
Join film_category ON film_category.film_id=film.film_id 
JOIN category ON category.category_id = film_category.category_id
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
WHERE category.name = 'Action' AND actor.first_name = 'Nick' AND actor.last_name = 'Stallone'
-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
Select address.address, address.address2, address.district, city.city, address.postal_code, country.country
FROM store
JOIN address on store.address_id = address.address_id
JOIN city ON city.city_id = address.city_id
JOIN country ON city.country_id = country.country_id


-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
Select address.address,  address.district, city.city, staff.first_name, staff.last_name
from store
JOIN staff ON store.manager_staff_id = staff.staff_id
JOIN address on store.address_id = address.address_id
JOIN city ON city.city_id = address.city_id
ORDER BY store.store_id


-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT TOP 10 COUNT(rental.customer_id) as count,  customer.first_name, customer.last_name
FROM customer
JOIN rental on customer.customer_id = rental.customer_id
GROUP BY customer.first_name, customer.last_name
ORDER BY count desc



-- 14. The first and last name of the top ten customers ranked by dollars spent   
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

SELECT TOP 10 customer.customer_id, customer.first_name, customer.last_name, SUM(payment.amount) as amount
FROM customer
JOIN payment ON customer.customer_id = payment.customer_id
GROUP BY payment.customer_id, customer.customer_id, customer.first_name, customer.last_name
ORDER BY amount desc


--customer.first_name , customer.last_name
-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.***
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)
SELECT s.store_id, a.address,(COUNT(r.rental_id)), (SUM(p.amount)), (AVG(p.amount))
FROM Store s
Join inventory i ON s.store_id = i.store_id
JOIN rental r ON i.inventory_id = r.inventory_id
JOIN payment p ON r.rental_id = p.rental_id
JOIN address a ON s.address_id = a.address_id
GROUP BY s.store_id, a.address



-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT TOP 10 (film.title), Count(rental.rental_date) AS rental
FROM film 
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON inventory.inventory_id= rental.inventory_id
GROUP BY film.title
ORDER BY rental desc


-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT TOP 5 (category.name), Count(rental.rental_date) AS rental
FROM category
JOIN film_category ON category.category_id = film_category.category_id
JOIN film ON film.film_id = film_category.film_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON inventory.inventory_id = rental.inventory_id
GROUP BY category.name
ORDER BY rental desc

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT TOP 5(film.title), Count(rental.rental_date) AS rental
FROM film
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON film_category.category_id = category.category_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON inventory.inventory_id = rental.inventory_id
WHERE category.name = ('Action')
GROUP BY film.title
ORDER BY rental desc

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)


SELECT TOP 10 film_actor.actor_id, actor.first_name, actor.last_name, COUNT(rental.rental_id) as counts
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
JOIN inventory ON film_actor.film_id = inventory.film_id
JOIN rental ON inventory.inventory_id = rental.inventory_id
GROUP BY film_actor.actor_id, actor.first_name, actor.last_name
ORDER BY counts DESC




-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor ***
-- (#1 should have 87 rentals and #5 should have 72 rentals)
--SELECT TOP 5 actor.first_name, actor.last_name, COUNT(*) AS rental
--From actor
--Join film_actor ON actor.actor_id = film_actor.actor_id
--Join film ON film_actor.film_id = film.film_id
--JOIN film_category ON film.film_id = film_category.film_id
--JOIN category ON film_category.film_id = category.category_id
--JOIN inventory ON film.film_id = inventory.film_id
--JOIN rental ON inventory.inventory_id = rental.inventory_id
--WHERE category.name = 'Comedy'
--GROUP BY actor.actor_id, actor.first_name, actor.last_name
--ORDER BY rental desc


SELECT a.actor_id, a.first_name, a.last_name, COUNT(*) AS rentals 
FROM rental r
JOIN inventory i ON r.inventory_id = i.inventory_id
JOIN film f ON f.film_id = i.film_id
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON c.category_id = fc.category_id
JOIN film_actor fa ON fa.film_id = f.film_id
JOIN actor a ON a.actor_id = fa.actor_id
WHERE c.name = 'Comedy' 
GROUP BY a.actor_id, a.first_name, a.last_name
ORDER BY rentals desc
--group by is non aggregated fields

