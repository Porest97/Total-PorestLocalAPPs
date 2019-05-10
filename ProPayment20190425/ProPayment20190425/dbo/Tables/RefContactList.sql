CREATE TABLE [dbo].[RefContactList] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Ssn]           BIGINT         NOT NULL,
    [FirstName]     NVARCHAR (MAX) NULL,
    [LastName]      NVARCHAR (MAX) NULL,
    [StreetAddress] NVARCHAR (MAX) NULL,
    [City]          NVARCHAR (MAX) NULL,
    [ZipCode]       NVARCHAR (MAX) NULL,
    [Country]       NVARCHAR (MAX) NULL,
    [Email]         NVARCHAR (MAX) NULL,
    [RefNumber]     INT            NULL,
    [PhoneNumber]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_RefContactList] PRIMARY KEY CLUSTERED ([Id] ASC)
);

