CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [EMPID] NCHAR(10) NOT NULL, 
    [Name] NCHAR(10) NULL, 
    [Phone] NCHAR(10) NULL, 
    [Role] NCHAR(10) NULL, 
    [Password] NCHAR(10) NULL
)
