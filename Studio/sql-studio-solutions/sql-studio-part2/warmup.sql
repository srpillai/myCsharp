# Return mystery book titles and ISBNs

SELECT title, isbn
FROM book WHERE genre_id IN (SELECT genre_id FROM genre WHERE genres LIKE 'Mystery');

# Return all of the titles and author’s first and last names for books written by authors who are currently living.

SELECT book.title, author.first_name, author.last_name FROM book INNER JOIN author ON book.author_id = author.author_id WHERE author.deathday IS NULL;