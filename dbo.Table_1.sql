CREATE TABLE [dbo].[Stock]
(
	[StockID] INT NOT NULL PRIMARY KEY, 
    [AuthorID] INT NOT NULL, 
    [ISBN-13] NCHAR(20) NOT NULL, 
    [QuantityInStock] INT NULL, 
    [DateRecorded] DATE NULL, 
    CONSTRAINT [AutorID] FOREIGN KEY ([AuthorID]) REFERENCES [Author]([AuthorID]), 
    CONSTRAINT [ISBN-13] FOREIGN KEY ([ISBN-13]) REFERENCES [Book]([ISBN-13])
)
