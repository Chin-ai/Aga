﻿CREATE TABLE [dbo].[Mas]
(
	[nmas] INT NOT NULL PRIMARY KEY, 
    [fio] NVARCHAR(50) NULL, 
    [dolj] NVARCHAR(50) NULL
	CONSTRAINT [master] PRIMARY KEY CLUSTERED ([nmas] ASC)
)
