CREATE TABLE [LoginApp].[Orders] (
	[OrderID]               INT             IDENTITY (1, 1) NOT NULL, 
    [BuyerId]               INT             NOT NULL,  
    [ProductName]           NVARCHAR (40)   NOT NULL,  
    [BuyerName]             NVARCHAR (40)   NOT NULL,  
    [BuyerAddress]          NVARCHAR (40)   NOT NULL,  
    [BuyerPhone]            NVARCHAR (40)   NOT NULL,  
    [PaymentMethod]         NVARCHAR (40)   NOT NULL,  
    [ProductPrice]          FLOAT           NOT NULL,
    [ProductStock]          INT             NOT NULL,
    [ProductIsDelieverd]    BIT             NOT NULL
);
GO  

PRINT N'Creating LoginApp.PK_Orders_OrderID...';  
GO  

ALTER TABLE [LoginApp].[Orders]  
    ADD CONSTRAINT [PK_SalesApp_OrderID] PRIMARY KEY CLUSTERED ([OrderID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);  
GO

PRINT N'Creating LoginApp.FK_Users_Orders_BuyerID...';  
GO  

ALTER TABLE [LoginApp].[Orders]  
    ADD CONSTRAINT [FK_Users_Orders_BuyerId] FOREIGN KEY ([BuyerId]) REFERENCES [LoginApp].[Users] ([UserID]) ON DELETE CASCADE ON UPDATE NO ACTION;  
GO

PRINT N'Creating Products.NewOrder...';  
GO  

CREATE PROCEDURE [LoginApp].[NewOrder]  
@BuyerId                INT,
@ProductName            NVARCHAR (40),  
@BuyerName              NVARCHAR (40),  
@BuyerAddress           NVARCHAR (40),  
@BuyerPhone             NVARCHAR (40),  
@PaymentMethod          NVARCHAR (40),  
@ProductPrice           FLOAT,
@ProductStock           INT,
@ProductDelievered      BIT, /*Because no bool type in sql server */
@OrderID                INT OUTPUT  
AS  
BEGIN  
INSERT INTO [LoginApp].[Orders] (BuyerId, ProductName, BuyerName, BuyerAddress,BuyerPhone, PaymentMethod, ProductPrice, ProductStock, ProductIsDelieverd) VALUES (@BuyerId, @ProductName, @BuyerName, @BuyerAddress, @BuyerPhone, @PaymentMethod, @ProductPrice, @ProductStock, @ProductDelievered);  
SET @OrderID = SCOPE_IDENTITY();  
RETURN @@ERROR  
END
GO  

CREATE PROCEDURE [LoginApp].[ShowOrders]  
AS  
BEGIN  
SELECT * 
  FROM [LoginApp].[Orders]  
END  
GO  