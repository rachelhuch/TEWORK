-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

INSERT INTO actor(first_name,last_name)
VALUES ('Hampton', 'Avenue'), ('Lisa', 'Byway')

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.


INSERT INTO film (title, description, release_year, language_id, length)
Values('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in
-- ancient Greece', 2008, 1, 198)


-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

SELECT actor_id
FROM actor
WHERE first_name = 'Hampton' AND last_name = 'Avenue'

INSERT INTO film_actor(film_id, actor_id)
VALUES (1001, 202), (1001, 201)

-- 4. Add Mathemagical to the category table.
INSERT INTO category (name)
VALUES ('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

INSERT INTO film_category (film_id, category_id)
Values(996, 17), (274, 17), (1001, 17), (494, 17), (714, 17)

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
UPDATE film
SET rating ='G'
WHERE film_id IN (996, 274, 1001, 494, 714)

-- 7. Add a copy of "Euclidean PI" to all the stores.

INSERT INTO inventory(film_id, store_id)
VALUES (1001, 1), (1001, 2)





-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)

DELETE from film
WHERE title= 'Euclidean PI'

-- <YOUR ANSWER HERE>
--No because it's being used in other tables - actor and film_actor

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE> No because it's being referenced in other tables
DELETE from category
WHERE name = 'Mathmagical'

-- 10. Delete all links to Mathmagical in the film_category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE> yes
DELETE 
FROM film_category 
WHERE category_id =17

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>
DELETE from category where name ='Mathmagical' --yes success
DELETE from film WHERE title = 'Euclidean PI'--no because it's still being used in film_actor, and film_id

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
--CANNOT REMEMBER how to access metadata but it is being used in film_actor and film_id