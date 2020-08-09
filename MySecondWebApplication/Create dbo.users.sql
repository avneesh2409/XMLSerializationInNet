USE [master]
GO

/****** Object: Table [dbo].[users] Script Date: 09-08-2020 11:30:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Email]    NVARCHAR (450) NOT NULL,
    [Password] NVARCHAR (MAX) NOT NULL,
    [Name]     NVARCHAR (MAX) NOT NULL
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_users_Email]
    ON [dbo].[users]([Email] ASC);


GO
ALTER TABLE [dbo].[users]
    ADD CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED ([Id] ASC);

GO
SELECT * FROM [dbo].[users];
