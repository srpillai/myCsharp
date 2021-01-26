# book_id is 10 and patron_id is 13

# Change available to TRUE for the appropriate book.

UPDATE book
SET available = TRUE
WHERE book_id = 10;

# Update the appropriate row in the loan table with today’s date as the date_in.

UPDATE loan 
SET date_in = CURDATE()
WHERE patron_id = 13 AND book_id = 10 AND date_in IS NULL;

# Update the appropriate patron changing loan_id back to null

UPDATE patron 
SET loan_id = NULL
WHERE patron_id = 13;