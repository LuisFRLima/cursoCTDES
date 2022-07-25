CREATE DATABASE [luisfelipe-d3-avaliacao];
GO

USE [luisfelipe-d3-avaliacao];
GO


CREATE TABLE Usuario(
	Id					int NOT NULL UNIQUE,
	[Nome]			    VARCHAR(255) NOT NULL,
	[Senha]				VARCHAR(255) NOT NULL,
	[Email]				VARCHAR(255) NOT NULL
);
GO


INSERT INTO Usuario
VALUES (1, 'admin', 'admin123', 'admin@email.com');
GO



	


