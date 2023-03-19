CREATE DATABASE RoskildeStudentHousingDB;

GO

USE RoskildeStudentHousingDB;

CREATE TABLE [dbo].[Student]
(
	[Id] VARCHAR(10) NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Dormitory]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Room] (
    [Id]     INT          NOT NULL,
    [Type]   VARCHAR (50) NOT NULL,
    [Price]  INT          NOT NULL,
    [DormId] INT          NOT NULL,
    PRIMARY KEY ([Id],[DormId]),
    CONSTRAINT [FK_Room_ToDormitory] FOREIGN KEY ([DormId]) REFERENCES [dbo].[Dormitory] ([Id]) ON DELETE CASCADE
	
);

CREATE TABLE [dbo].[Leasing] (
    [Id]        INT          NOT NULL,
    [DateFrom]  DATETIME     NOT NULL,
    [DateTo]    DATETIME     NOT NULL,
    [StudentId] VARCHAR (10) NOT NULL,
    [RoomId]    INT          NOT NULL,
	[DormId] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Leasing_ToStudent] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Leasing_ToRoom] FOREIGN KEY ([RoomId],[DormId]) REFERENCES [dbo].[Room] ([Id],[DormId]) ON DELETE CASCADE
);

--CREATE VIEW Occupied AS
--	SELECT Room.Id, Room.Type, Room.Price, Room.DormId FROM Room 
--	LEFT JOIN Leasing ON Room.Id = Leasing.RoomId 
--	LEFT JOIN Dormitory ON Dormitory.Id = Room.DormId 
--	where Leasing.DateTo >= getdate();

INSERT INTO [dbo].[Student] ([Id], [Name], [Address]) VALUES (N'chre38eb', N'Christian Canty', N'Holbæk')
INSERT INTO [dbo].[Student] ([Id], [Name], [Address]) VALUES (N'mads72q2', N' Mads Egelund Ludvigsen', N'Roskilde')
INSERT INTO [dbo].[Student] ([Id], [Name], [Address]) VALUES (N'mille0212', N'Mille Alstrøm', N'Slagelse')

INSERT INTO [dbo].[Dormitory] ([Id], [Name], [Address]) VALUES (1, N'Musicon', N'Rampelyset 1, 4000 Roskilde')
INSERT INTO [dbo].[Dormitory] ([Id], [Name], [Address]) VALUES (2, N'Silo', N'MagleHøjen 10, 4000 Roskilde ')
INSERT INTO [dbo].[Dormitory] ([Id], [Name], [Address]) VALUES (3, N'Spritfabrikken', N'Møllehusene 16, 4000 Roskilde')

INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (1, N'2 bedroom', 5604, 1)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (2, N'2 bedroom', 5709, 1)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (3, N'2 bedroom', 6108, 1)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (4, N'2 bedroom', 6208, 1)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (5, N'Studio', 4633, 2)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (6, N'Studio', 5830, 2)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (7, N'Studio', 6911, 2)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (8, N'2 bedroom', 5688, 2)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (9, N'2 bedroom', 6783, 2)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (10, N'2 bedroom', 7022, 2)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (11, N'Studio', 2877, 3)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (12, N'Studio', 3121, 3)
INSERT INTO [dbo].[Room] ([Id], [Type], [Price], [DormId]) VALUES (13, N'2 bedroom', 3300, 3)

INSERT INTO [dbo].[Leasing] ([Id], [DateFrom], [DateTo], [StudentId], [RoomId], [DormId]) VALUES (1, N'2022-01-01 12:00:00', N'2025-06-01 12:00:00', N'mads72q2', 1, 1)
INSERT INTO [dbo].[Leasing] ([Id], [DateFrom], [DateTo], [StudentId], [RoomId], [DormId]) VALUES (2, N'2022-02-01 12:00:00', N'2025-06-01 12:00:00', N'chre38eb', 10, 2)
INSERT INTO [dbo].[Leasing] ([Id], [DateFrom], [DateTo], [StudentId], [RoomId], [DormId]) VALUES (3, N'2022-03-01 00:00:00', N'2025-06-01 12:00:00', N'mille0212', 12, 3)
