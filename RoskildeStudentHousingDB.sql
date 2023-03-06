CREATE DATABASE RoskildeStudentHousingDB;

GO

USE RoskildeStudentHousingDB;

CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Dormitory]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Room]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Type] VARCHAR(50) NOT NULL, 
    [Price] INT NOT NULL, 
    [DormId] INT NOT NULL, 
    CONSTRAINT [FK_Room_ToDormitory] FOREIGN KEY ([DormId]) REFERENCES [Dormitory]([Id]) ON DELETE CASCADE
)

CREATE TABLE [dbo].[Leasing]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DateFrom] DATETIME NOT NULL, 
    [DateTo] DATETIME NOT NULL, 
    [StudentId] INT NOT NULL, 
    [RoomId] INT NOT NULL, 
    CONSTRAINT [FK_Leasing_ToStudent] FOREIGN KEY ([StudentId]) REFERENCES [Student]([Id]) ON DELETE CASCADE,  
    CONSTRAINT [FK_Leasing_ToRoom] FOREIGN KEY ([RoomId]) REFERENCES [Room]([Id]) ON DELETE CASCADE
)