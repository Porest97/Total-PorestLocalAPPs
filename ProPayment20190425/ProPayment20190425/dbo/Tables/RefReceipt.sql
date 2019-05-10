CREATE TABLE [dbo].[RefReceipt] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Ssn]               BIGINT         NOT NULL,
    [FirstName]         NVARCHAR (MAX) NULL,
    [LastName]          NVARCHAR (MAX) NULL,
    [StreetAddress]     NVARCHAR (MAX) NULL,
    [City]              NVARCHAR (MAX) NULL,
    [ZipCode]           NVARCHAR (MAX) NULL,
    [Country]           NVARCHAR (MAX) NULL,
    [Email]             NVARCHAR (MAX) NULL,
    [RefNumber]         INT            NULL,
    [LateMatchFee]      FLOAT (53)     NULL,
    [Allowance]         FLOAT (53)     NULL,
    [MatchFee]          FLOAT (53)     NULL,
    [TravelFrom]        NVARCHAR (MAX) NULL,
    [TravelTo]          NVARCHAR (MAX) NULL,
    [TravelDistance]    FLOAT (53)     NULL,
    [TravelFee]         FLOAT (53)     NULL,
    [TotalFee]          FLOAT (53)     NULL,
    [SwishNumber]       BIGINT         NOT NULL,
    [BankAccountNumber] BIGINT         NOT NULL,
    [Date]              NVARCHAR (MAX) NULL,
    [Signature]         NVARCHAR (MAX) NULL,
    [MatchId]           INT            NULL,
    CONSTRAINT [PK_RefReceipt] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RefReceipt_Match_MatchId] FOREIGN KEY ([MatchId]) REFERENCES [dbo].[Match] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_RefReceipt_MatchId]
    ON [dbo].[RefReceipt]([MatchId] ASC);

