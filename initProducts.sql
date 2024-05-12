USE Products;

CREATE
TABLE Stock
(id INTEGER PRIMARY KEY,
productName VARCHAR(512),
shortDescription VARCHAR(1024),
unitPrice DECIMAL(10,2));

INSERT
INTO Stock
VALUES (1, 'Ali Babas Fish Curry Powder', 'Packet', '6.99');

INSERT
INTO Stock
VALUES (2, 'Apollo Chocolate Cake', '8 pieces box', '9.99');

INSERT
INTO Stock
VALUES (3, 'Alicafe Original Instant', 'Pack of 20', '14.99');