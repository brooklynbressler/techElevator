USE assessment;
GO

-- Select all columns from posts that are published

SELECT *
FROM posts
WHERE published = 1;

-- Select posted_by and body from comments that have a body and were created after Oct. 15, 2019

SELECT c.posted_by, c.body
FROM comments c
JOIN posts p ON p.id = c.post_id
WHERE p.body IS NOT NULL AND p.created > '2019-10-15';

-- Select the name and published states from posts ordered by when they were created, earliest first

SELECT name, published
FROM posts
ORDER BY created ASC;

-- Select the created date and the count of all the comments created on that date

SELECT COUNT(created) AS comment_amount, created
FROM comments
GROUP BY created;

-- Select the post name, comment posted_by and comment body for all posts created after Oct. 1st, 2019

SELECT p.name, c.posted_by, c.body
FROM posts p
JOIN comments c ON c.post_id = p.id
WHERE p.created > '2019-10-01';

SELECT body, created, id, published, name 
FROM posts;

INSERT INTO posts(name, body, published, created)
VALUES ('@name', '@body', @published, '@created');