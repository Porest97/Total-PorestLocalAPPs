CREATE TABLE [dbo].[RefFee] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [RefFeeName]     NVARCHAR (MAX) NULL,
    [RefFeeCategory] NVARCHAR (MAX) NULL,
    [RefFeeValue]    FLOAT (53)     NULL,
    CONSTRAINT [PK_RefFee] PRIMARY KEY CLUSTERED ([Id] ASC)
);

