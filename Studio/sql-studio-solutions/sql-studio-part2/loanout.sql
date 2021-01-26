# book id used is 10, patron id used is 13

# Change available to FALSE for the appropriate book.

UPDATE book
SET available = FALSE
WHERE book_id = 10;

# Add a new row to the loan table with today’s date as the date_out and the ids in the row matching the appropriate patron_id and book_id.

INSERT INTO loan (patron_id, date_out, book_id)
VALUES (13, CURDATE(),10);

# Update the appropriate patron with the loan_id for the new row created in the loan table.

UPDATE patron
SET loan_id = (SELECT loan_id FROM loan WHERE patron_id = 13)
WHERE patron_id = 13;
