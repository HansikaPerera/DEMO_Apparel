CREATE TABLE [dbo].[Table]
(
	[ItemNo] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Description] VARCHAR(50) NULL, 
    [UnitPrice] FLOAT NULL, 
    [Location] VARCHAR(50) NULL, 
    [Stock] INT NULL, 
    [LineVal] INT NULL, 
    [PriceCat] VARCHAR(50) NULL
)
