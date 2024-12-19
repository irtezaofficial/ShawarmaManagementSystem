
Create Database ShawarmaManagementSystem;

CREATE TABLE Users (
    "UserName" VARCHAR(100),
	"Password" VARCHAR(100),
  "Type" VARCHAR(100)
);

CREATE TABLE Shawarma (
    "Name" VARCHAR(100),
	"Type" VARCHAR(100),
	"Price" DECIMAL,
	"Quantity" INT
);

CREATE TABLE Invoice(
    "Name" VARCHAR(100),
	"Quantity" INT,
	"Price" INT,
  "TotalAmount" decimal,
 "Date" date,
 "PaymentType" VARCHAR(100)
);

INSERT INTO Users ("UserName", "Password", "Type")
VALUES ('user', 'user', 'User');

INSERT INTO Users ("UserName", "Password", "Type")
VALUES ('admin', 'admin', 'Admin');

select * from Users;
select * from Shawarma;
select * from Invoice;

DELETE from Users;
DELETE from Shawarma;
DELETE from Invoice;