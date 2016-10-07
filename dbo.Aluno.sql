CREATE TABLE [dbo].[Aluno] (
    [Id]    INT          NOT NULL IDENTITY,
    [Nome]  VARCHAR (50) NOT NULL,
    [Email] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

