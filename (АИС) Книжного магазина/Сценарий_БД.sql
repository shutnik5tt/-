-- Разработка графического приложения автоматизированной информационной системы (АИС) книжного магазина

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'AIS_Bookstore')
BEGIN
    CREATE DATABASE [AIS_Bookstore];
END

USE [AIS_Bookstore]

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'transaction_book_copy')
BEGIN
    DROP TABLE transaction_book_copy;
END

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'transaction')
BEGIN
    DROP TABLE [transaction];
END

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'user')
BEGIN
    DROP TABLE [user];
END

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'position')
BEGIN
    DROP TABLE position;
END

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'book_copy')
BEGIN
    DROP TABLE book_copy;
END

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'book_author')
BEGIN
    DROP TABLE book_author;
END

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'book_genre')
BEGIN
    DROP TABLE book_genre;
END

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'store')
BEGIN
    DROP TABLE store;
END

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'genre')
BEGIN
    DROP TABLE genre;
END

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'author')
BEGIN
    DROP TABLE author;
END

IF EXISTS (SELECT name FROM sys.tables WHERE name = 'book')
BEGIN
    DROP TABLE book;
END

CREATE TABLE book (
    id_book INT PRIMARY KEY IDENTITY(1,1),
    name_book NVARCHAR(256) NOT NULL,
    description_book NVARCHAR(MAX) NULL,
    pages_book INT NOT NULL,
    publication_year_book INT NOT NULL,
    price_book DECIMAL(10,2) NOT NULL
);

CREATE TABLE author (
    id_author INT PRIMARY KEY IDENTITY(1,1),
    lastname_author NVARCHAR(64) NOT NULL,
    name_author NVARCHAR(64) NOT NULL,
    middlename_author NVARCHAR(64) NULL,
    birth_year_author INT NULL
);

CREATE TABLE genre (
    id_genre INT PRIMARY KEY IDENTITY(1,1),
    name_genre NVARCHAR(64) NOT NULL
);

CREATE TABLE store (
    id_store INT PRIMARY KEY IDENTITY(1,1),
    city_store NVARCHAR(64) NOT NULL,
    street_store NVARCHAR(128) NOT NULL,
    house_store NVARCHAR(16) NOT NULL,
    phone_store NVARCHAR(20) NOT NULL
);

CREATE TABLE book_author (
    id_book_author INT PRIMARY KEY IDENTITY(1,1),
    id_book INT NOT NULL REFERENCES book(id_book),
    id_author INT NOT NULL REFERENCES author(id_author)
);

CREATE TABLE book_genre (
    id_book_genre INT PRIMARY KEY IDENTITY(1,1),
    id_book INT NOT NULL REFERENCES book(id_book),
    id_genre INT NOT NULL REFERENCES genre(id_genre)
);

CREATE TABLE book_copy (
    id_book_copy INT PRIMARY KEY IDENTITY(1,1),
    id_book INT NOT NULL REFERENCES book(id_book),
    id_store INT NOT NULL REFERENCES store(id_store),
    status_book_copy NVARCHAR(20) NOT NULL CHECK (status_book_copy IN ('В наличии', 'Продано'))
);

CREATE TABLE position (
    id_position INT PRIMARY KEY IDENTITY(1,1),
    name_position NVARCHAR(64) NOT NULL
);

CREATE TABLE [user] (
    id_user INT PRIMARY KEY IDENTITY(1,1),
    id_position INT NOT NULL REFERENCES position(id_position) DEFAULT 1,
    lastname_user NVARCHAR(64) NOT NULL,
    name_user NVARCHAR(64) NOT NULL,
    middlename_user NVARCHAR(64) NULL,
    phone_user NVARCHAR(20) NOT NULL
);

CREATE TABLE [transaction] (
    id_transaction INT PRIMARY KEY IDENTITY(1,1),
    id_user INT NULL REFERENCES [user](id_user),
    payment_type_transaction NVARCHAR(20) NOT NULL CHECK (payment_type_transaction IN ('Наличными', 'Онлайн')),
    amount_transaction DECIMAL(10,2) NOT NULL,
    status_transaction NVARCHAR(20) NOT NULL CHECK (status_transaction IN ('В пути', 'Готово к выдаче', 'Выдано'))
);

CREATE TABLE transaction_book_copy (
    id_transaction_book_copy INT PRIMARY KEY IDENTITY(1,1),
    id_transaction INT NOT NULL REFERENCES [transaction](id_transaction),
    id_book_copy INT NOT NULL REFERENCES book_copy(id_book_copy)
);