PRINT N'CREATING LOGINAPP...'
GO

CREATE SCHEMA [LoginApp]
	AUTHORIZATION [dbo]
GO

PRINT 'CREATING TABLE Products'
GO

CREATE TABLE [LoginApp].[Products] (
	[ProductID]             INT             IDENTITY (1, 1) NOT NULL,  
    [ProductName]           NVARCHAR (40)   NOT NULL,  
    [ProductDescription]    NVARCHAR (40)   NOT NULL,
    [ProductPrice]          FLOAT           NOT NULL,
    [ProductStock]          INT             NOT NULL,
    [ProductIsBlocked]      BIT             NOT NULL
);
GO  

PRINT N'Creating LoginApp.PK_Products_ProductID...';  
GO  

ALTER TABLE [LoginApp].[Products]  
    ADD CONSTRAINT [PK_SalesApp_ProductID] PRIMARY KEY CLUSTERED ([ProductID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);  
GO  

PRINT N'Creating LoginApp.FK_Users_Products_UserID...';  
GO  

ALTER TABLE [LoginApp].[Products]  
    ADD CONSTRAINT [FK_Users_Products_UserID] FOREIGN KEY ([UserID]) REFERENCES [LoginApp].[Users] ([UserID]) ON DELETE NO ACTION ON UPDATE NO ACTION;  
GO

PRINT N'Creating Products.NewProduct...';  
GO  

CREATE PROCEDURE [LoginApp].[NewProduct]  
@ProductName NVARCHAR (40),  
@ProductDescription NVARCHAR (40),  
@ProductPrice FLOAT,
@ProductStock INT,
@ProductBlock BIT, /*Because no bool type in sql server */
@ProductID INT OUTPUT  
AS  
BEGIN  
INSERT INTO [LoginApp].[Products] (ProductName, ProductDescription, ProductPrice, ProductStock, ProductIsBlocked) VALUES (@ProductName, @ProductDescription, @ProductPrice, @ProductStock, @ProductBlock);  
SET @ProductID = SCOPE_IDENTITY();  
RETURN @@ERROR  
END
GO  

CREATE PROCEDURE [LoginApp].[ShowProductDetails]  
@ProductName NVARCHAR (40)  
AS  
BEGIN  
SELECT * 
  FROM [LoginApp].[Products] AS P  
  WHERE [P].[ProductName] = @ProductName  
END  
GO  