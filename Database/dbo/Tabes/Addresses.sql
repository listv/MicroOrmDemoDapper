CREATE TABLE [dbo].[Addresses]
(
	[Id]			INT			 IDENTITY(1,1) NOT NULL, 
    [ContactId]		INT			 NOT NULL, 
    [AddressType]	NVARCHAR(10) NOT NULL, 
    [StreetAddress] NVARCHAR(50) NOT NULL, 
    [City]			NVARCHAR(50) NOT NULL, 
    [StateId]		INT			 NOT NULL, 
    [PostalCode]	NVARCHAR(20) NOT NULL,
	CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Addresses_Contacts] FOREIGN KEY ([ContactId]) REFERENCES [dbo].[Contacts]([Id]),
	CONSTRAINT [FK_Addresses_States] FOREIGN KEY ([StateId]) REFERENCES [dbo].[States]([Id])
)
