PRINT N'CREATING LOGINAPP...'
GO

CREATE SCHEMA [LoginApp]
	AUTHORIZATION [dbo]
GO

PRINT 'CREATING TABLE USERS'
GO

CREATE TABLE [LoginApp].[Users] (
	[UserID]   INT           IDENTITY (1, 1) NOT NULL,  
    [UserName] NVARCHAR (40) NOT NULL,  
    [UserPass] NVARCHAR (40) NOT NULL,  
);
GO  

PRINT N'Creating LoginApp.PK_Users_UserID...';  
GO  

ALTER TABLE [LoginApp].[Users]  
    ADD CONSTRAINT [PK_SalesApp_UserID] PRIMARY KEY CLUSTERED ([UserID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);  
GO  

PRINT N'Creating Users.uspNewUser...';  
GO  

CREATE PROCEDURE [LoginApp].[uspNewUser]  
@UserName NVARCHAR (40),  
@UserPass NVARCHAR (40),  
@UserRole NVARCHAR (40),  
@UserID INT OUTPUT  
AS  
BEGIN  
INSERT INTO [LoginApp].[Users] (UserName, UserPass, UserRole) VALUES (@UserName, @UserPass, @UserRole);  
SET @UserID = SCOPE_IDENTITY();  
RETURN @@ERROR  
END
GO  

CREATE PROCEDURE [LoginApp].[uspShowUserDetails]  
@UserName NVARCHAR (40)  
AS  
BEGIN  
SELECT [C].[UserName], [C].[UserPass] 
  FROM [LoginApp].[Users] AS C  
  WHERE [C].[UserName] = @UserName  
END  
GO