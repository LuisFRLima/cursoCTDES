CREATE DATABASE [luisfelipe-d7-avaliacao];
GO

USE [luisfelipe-d7-avaliacao];
GO


CREATE TABLE Usuario(
	Id					int NOT NULL UNIQUE,
	[Email]				VARCHAR(255) NOT NULL,
	[Senha]				VARCHAR(255) NOT NULL
);
GO


INSERT INTO Usuario
VALUES (1,'admin@email.com','admin123');
GO
