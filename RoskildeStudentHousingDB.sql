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