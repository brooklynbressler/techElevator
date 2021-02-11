 -- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)

SELECT 
		(a.first_name + ' , ' + a.last_name) actor_name, f.title
FROM 
		actor a
JOIN 
		film_actor fa ON fa.actor_id = a.actor_id
JOIN 
		film f ON f.film_id = fa.film_id
WHERE 
		a.first_name LIKE 'NICK' AND a.last_name LIKE 'STALLONE';

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)

SELECT 
		(a.first_name + ' , ' + a.last_name) actor_name, f.title
FROM 
		actor a
JOIN 
		film_actor fa ON fa.actor_id = a.actor_id
JOIN 
		film f ON f.film_id = fa.film_id
WHERE 
		a.first_name LIKE 'RITA' AND a.last_name LIKE 'REYNOLDS';

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)

SELECT 
		(a.first_name + ' , ' + a.last_name) actor_name, f.title
FROM 
		actor a
JOIN 
		film_actor fa ON fa.actor_id = a.actor_id
JOIN 
		film f ON f.film_id = fa.film_id
WHERE 
		a.first_name LIKE 'JUDY' AND a.last_name LIKE 'DEAN' OR
		a.first_name LIKE 'RIVER' AND a.last_name LIKE 'DEAN';

-- 4. All of the the ‘Documentary’ films
-- (68 rows)

SELECT 
		c.name genre, f.title
FROM 
		film f
JOIN 
		film_category fc ON fc.film_id = f.film_id
JOIN 
		category c ON fc.category_id = c.category_id
WHERE 
		c.name LIKE 'Documentary';

-- 5. All of the ‘Comedy’ films
-- (58 rows)

SELECT 
		c.name genre, f.title
FROM 
		film f
JOIN 
		film_category fc ON fc.film_id = f.film_id
JOIN 
		category c ON fc.category_id = c.category_id
WHERE 
		c.name LIKE 'Comedy';

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)

SELECT 
		c.name genre, f.title, f.rating
FROM 
		film f
JOIN 
		film_category fc ON fc.film_id = f.film_id
JOIN 
		category c ON fc.category_id = c.category_id
WHERE 
		c.name LIKE 'Children' AND f.rating LIKE 'G';

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)

SELECT 
		c.name genre, f.title, f.rating, f.length
FROM 
		film f
JOIN 
		film_category fc ON fc.film_id = f.film_id
JOIN 
		category c ON fc.category_id = c.category_id
WHERE 
		c.name LIKE 'Family' AND f.rating LIKE 'G' AND f.length < 120;

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)

SELECT 
		(a.first_name + ', ' + a.last_name) actor_name, f.title, f.rating
FROM 
		actor a
JOIN 
		film_actor fa ON fa.actor_id = a.actor_id
JOIN 
		film f ON f.film_id = fa.film_id
WHERE 
		a.first_name LIKE 'MATTHEW' AND a.last_name LIKE 'LEIGH' AND
		f.rating LIKE 'G';

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)

SELECT 
		f.title, c.name genre, f.release_year
FROM 
		film f
JOIN 
		film_category fc ON fc.film_id = f.film_id
JOIN 
		category c ON c.category_id = fc.category_id
WHERE 
		c.name LIKE 'Sci-Fi' AND f.release_year = 2006;

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)

SELECT 
		c.name genre, f.title, (a.first_name + ', ' + a.last_name) actor_name
FROM 
		film f
JOIN 
		film_actor fa ON fa.film_id = f.film_id
JOIN 
		actor a ON a.actor_id = fa.actor_id
JOIN 
		film_category fc ON fc.film_id = f.film_id
JOIN 
		category c ON c.category_id = fc.category_id
WHERE 
		a.first_name LIKE 'NICK' AND a.last_name LIKE 'STALLONE' AND c.name LIKE 'Action';

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)

SELECT 
		s.store_id, a.address, ci.city, a.district, co.country
FROM 
		address a
JOIN 
		city ci ON ci.city_id = a.city_id
JOIN 
		country co ON co.country_id = ci.country_id
JOIN 
		store s ON s.address_id = a.address_id; 

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)

SELECT 
		sto.store_id, a.address, (sta.first_name + ', ' + sta.last_name) manager_name
FROM 
		store sto
JOIN 
		address a ON sto.address_id = a.address_id
JOIN 
		staff sta ON sto.store_id = sta.store_id;

-- 13. The first and last name of the top ten customers ranked by number of rentals
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)

SELECT TOP (10) 
		(cu.first_name + ', ' + cu.last_name) customer_name, COUNT(r.customer_id) rental_amount
FROM 
		customer cu
JOIN 
		rental r ON r.customer_id = cu.customer_id
GROUP BY 
		r.customer_id, cu.first_name, cu.last_name
ORDER BY 
		rental_amount DESC;

-- 14. The first and last name of the top ten customers ranked by dollars spent
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

SELECT TOP (10) 
		(cu.first_name + ', ' + cu.last_name) customer_name, SUM(p.amount) money_spent
FROM 
		customer cu
JOIN 
		payment p ON p.customer_id = cu.customer_id
GROUP BY 
		cu.customer_id, cu.first_name, cu.last_name
ORDER BY 
		money_spent DESC;

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that while a customer has only one primary store, they may rent from either store.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

SELECT 
		sto.store_id, a.address, COUNT(p.staff_id) number_of_rentals, SUM(p.amount) total_sales_amount, AVG(p.amount) avg_sale_amount
FROM 
		store sto
JOIN 
		address a ON a.address_id = sto.address_id
JOIN 
		inventory i ON i.store_id = sto.store_id
JOIN 
		rental r ON r.inventory_id = i.inventory_id
JOIN 
		payment p ON p.rental_id = r.rental_id
GROUP BY 
		sto.store_id, a.address
ORDER BY 
		number_of_rentals ASC;

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)

SELECT TOP (10) 
		f.title, COUNT(r.rental_id) number_of_rentals
FROM 
		film f
JOIN 
		inventory i ON i.film_id = f.film_id
JOIN 
		rental r ON r.inventory_id = i.inventory_id
GROUP BY 
		f.title
ORDER BY 
		number_of_rentals DESC;


-- 17. The top five film categories by number of rentals
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)

SELECT TOP (5) 
		c.name, COUNT(r.rental_id) number_of_rentals
FROM 
		film f
JOIN 
		inventory i ON i.film_id = f.film_id
JOIN 
		rental r ON r.inventory_id = i.inventory_id
JOIN 
		film_category fc ON fc.film_id = f.film_id
JOIN 
		category c ON c.category_id = fc.category_id
GROUP BY 
		c.name
ORDER BY 
		number_of_rentals DESC;

-- 18. The top five Action film titles by number of rentals
-- (#1 should have 30 rentals and #5 should have 28 rentals)

SELECT TOP (5) 
		c.name, f.title, COUNT(r.rental_id) number_of_rentals
FROM 
		film f
JOIN 
		inventory i ON i.film_id = f.film_id
JOIN 
		rental r ON r.inventory_id = i.inventory_id
JOIN 
		film_category fc ON fc.film_id = f.film_id
JOIN 
		category c ON c.category_id = fc.category_id
WHERE 
		c.name = 'Action'
GROUP BY 
		f.title, c.name
ORDER BY 
		number_of_rentals DESC;


-- 19. The top 10 actors ranked by number of rentals of films starring that actor
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)

SELECT TOP (10) 
		(a.first_name + ' ' + a.last_name) actor_name, COUNT(r.rental_id) rental_number
FROM 
		actor a
JOIN 
		film_actor fa ON fa.actor_id = a.actor_id
JOIN 
		film f ON f.film_id = fa.film_id
JOIN 
		inventory i ON i.film_id = f.film_id
JOIN 
		rental r ON r.inventory_id = i.inventory_id
GROUP BY 
		a.actor_id, a.first_name, a.last_name
ORDER BY 
		rental_number DESC;

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor
-- (#1 should have 87 rentals and #5 should have 72 rentals)

SELECT TOP (5) 
		c.name, (a.first_name + ' ' + a.last_name) actor_name, COUNT(r.rental_id) rental_number
FROM 
		actor a
JOIN 
		film_actor fa ON fa.actor_id = a.actor_id
JOIN 
		film f ON f.film_id = fa.film_id
JOIN 
		inventory i ON i.film_id = f.film_id
JOIN 
		rental r ON r.inventory_id = i.inventory_id
JOIN 
		film_category fc ON fc.film_id = f.film_id
JOIN 
		category c ON c.category_id = fc.category_id
WHERE 
		c.name = 'Comedy'
GROUP BY 
		a.actor_id, a.first_name, a.last_name, c.name
ORDER BY 
		rental_number DESC;