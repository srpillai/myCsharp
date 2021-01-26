# Return the counts of the books of each genre. Check out the documentation to see how this could be done!

SELECT genre_id, COUNT(*) FROM book GROUP BY genre_id;

-- Alternatively, return the counts of the books from each genre and include the name of the genre.

SELECT book.genre_id, COUNT(*), genres
FROM book
INNER JOIN genre ON genre.genre_id = book.genre_id
GROUP BY book.genre_id;

# A reference book cannot leave the library. How would you modify either the reference_book table or the book table to make sure that doesn’t happen? Try to apply your modifications.

UPDATE book
SET available = CASE
	WHEN genre_id = 25 THEN available
    ELSE FALSE
    END
WHERE book_id = 10;

# This is one way this may be accomplished. The focus on the final bonus mission is really more on thinking through the problem and investigating online to see if it can be done. If someone codes something, that is great!
