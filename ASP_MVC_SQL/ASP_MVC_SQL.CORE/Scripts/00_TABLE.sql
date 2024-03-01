CREATE DATABASE ASP_MVC_SQL
GO


CREATE TABLE TB_Cliente(
Id INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(50) Not NULL,
)

SELECT * FROM TB_Cliente

INSERT INTO TB_Cliente(Nome)
VALUES('Jogo')


USE [master];
GO

CREATE LOGIN userTeste01
    WITH PASSWORD    = N'123456',
    CHECK_POLICY     = OFF,
    CHECK_EXPIRATION = OFF;
GO

EXEC sp_addsrvrolemember 
    @loginame = N'userTeste01', 
    @rolename = N'sysadmin';