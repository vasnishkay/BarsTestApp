CREATE TABLE [dbo].[Contract]
(
	[ContractNumber] INT NOT NULL IDENTITY(1,1),
	[CreatedOn] DATETIME NOT NULL,
	[LatestUpdate] DATETIME NOT NULL,
	CONSTRAINT PK_ContractNumber PRIMARY KEY CLUSTERED (ContractNumber)
)
