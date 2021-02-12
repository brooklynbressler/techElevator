-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

INSERT INTO 
		actor (first_name, last_name)
VALUES 
		('HAMPTON', 'AVENUE')
INSERT INTO 
		actor (first_name, last_name)
VALUES 
		('LISA', 'BYWAY');

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

INSERT INTO 
		film (title, description, release_year, language_id, rental_duration, rental_rate, length, replacement_cost)
VALUES 
		('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, 7, 0.99, 198, 10.99);

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
-- HAMPTON id = 205
-- LISA id = 206
-- Euclidean id = 1002

INSERT INTO
		film_actor (actor_id, film_id)
VALUES
		(205, 1002)
INSERT INTO 
		film_actor (actor_id, film_id)
VALUES
		(206, 1002);

-- 4. Add Mathmagical to the category table.

INSERT INTO 
		category (name)
VALUES 
		('Mathmagical');

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
-- Mathmagical Category id is 18

INSERT INTO
		film_category (film_id, category_id)
VALUES
		(1002, 18);
UPDATE
		film_category
SET
		category_id = 18
WHERE
		film_id = 274;
UPDATE
		film_category
SET
		category_id = 18
WHERE
		film_id = 494;
UPDATE
		film_category
SET
		category_id = 18
WHERE
		film_id = 714;
UPDATE
		film_category
SET
		category_id = 18
WHERE
		film_id = 996;

--		***SIDE NOTE***

--		After completing number 6 I realized I could have put all of
--		my updates from number 5 into one update. Lesson learned! :D

--		***SIDE NOTE***

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

UPDATE
		film
SET
		rating = 'G'
WHERE
		film_id = 714 OR film_id = 494 OR film_id = 274;

-- 7. Add a copy of "Euclidean PI" to all the stores.

INSERT INTO
		inventory (film_id, store_id)
VALUES
		(1002, 1);
INSERT INTO
		inventory (film_id, store_id)
VALUES
		(1002, 2);

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

--		***ANSWER***

--		No, unfortunately attempting to delete "Euclidean PI" from the film table didn't succeed due 
--		to the film_actor foreign key constraint concerning the column film_id.

--		***ANSWER***

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

--		***ANSWER***

--		No, unfortunately attempting to delete "Mathmagical" from the category table didn't succeed due 
--		to the film_category foreign key constraint concerning the column category_id.

--		***ANSWER***

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>

--		***ANSWER***

--		Yes! Fortunately deleting all links to "Mathmagical" from the film_category table did succeed due 
--		there being no constraints. There are no constraints because there are no other links to the 
--		"Mathmagical" category anywhere else.

--		***ANSWER***

DELETE FROM
			film_category
WHERE
		category_id = 18;

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>

--		***ANSWER***

--		Yes! Fortunately deleting "Mathmagical" from the category table did succeed due 
--		there being no constraints. There are no constraints because there are no other links to the 
--		"Mathmagical" category anywhere else. Unfortunately, attempting to delete "Euclidean PI" from the 
--		film table didn't succeed due to the film_actor foreign key constraint concerning the column film_id.

--		***ANSWER***

DELETE FROM	
			category
WHERE
		category_id = 18;

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

--		***ANSWER***

--		I believe you would have to delete or update the film_id from the film_actor, film_category, and
--		inventory tables before actually being able to remove the film "Euclidean PI" from the film table.

--		***ANSWER***