# Return names of the patrons with the genre of every book they currently have checked out.

-- Retrieve first name, last name, and genre of checked out books.
SELECT patron_loan.first_name, patron_loan.last_name, genres
FROM (
	-- Return first name, last name, and book_id from the patron_loan table.
	SELECT first_name, last_name, book_id
    FROM patron
    -- Merge entries from the loan and patron tables that have the same loan_id.
    INNER JOIN loan ON loan.loan_id = patron.loan_id
) AS patron_loan
-- Merge entries from the patron_loan and genre_book tables that have the same book_id.
INNER JOIN (
	SELECT genres, book_id
    FROM genre
    -- Merge the genre and book table entries.
    INNER JOIN book ON genre.genre_id = book.genre_id
) AS genre_book
ON genre_book.book_id = patron_loan.book_id;

# Alternative approach:

SELECT first_name, last_name, genres
FROM (
	SELECT first_name, last_name, book_id
	FROM patron
	INNER JOIN loan ON loan.loan_id = patron.loan_id
) AS patron_loan
-- Merge entries from patron_loan and checked_out_genres that have mathcing book_id values.
INNER JOIN (
	-- Return entries for books that are NOT available.
	SELECT book_id, genre_id
    FROM book
    WHERE available = FALSE
) AS checked_out_genres ON patron_loan.book_id = checked_out_genres.book_id
-- Merge entries from genre and checked_out_genres that have mathcing genre_id values.
INNER JOIN genre ON checked_out_genres.genre_id = genre.genre_id;
