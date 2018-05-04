CREATE TABLE Users (
UsersId INT	NOT NULL IDENTITY (1,1) PRIMARY KEY,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR (50) NOT NULL,
BirthDate DATETIME NOT NULL);

CREATE TABLE Rewards (
[RewardsId] INT	NOT NULL IDENTITY (1,1) PRIMARY KEY,
[Title] NVARCHAR(50) NOT NULL,
[Description] NVARCHAR (250) NOT NULL);

CREATE TABLE UserRewards (
UserRewardId INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
[UsersId] INT NOT NULL FOREIGN KEY REFERENCES Users(UsersId) ON DELETE CASCADE,
[RewardsId] INT NOT NULL FOREIGN KEY REFERENCES Rewards(RewardsId)) ON DELETE CASCADE;

GO
CREATE PROCEDURE AddReward
	@Title NVARCHAR(50),
	@Description NVARCHAR (250)
AS
INSERT INTO Rewards (Title, [Description])
VALUES (@Title, @Description)

GO
CREATE PROCEDURE AddUser
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR (50),
	@BirthDate DATETIME
AS
INSERT INTO Users (FirstName, LastName, BirthDate)
OUTPUT inserted.UsersId
VALUES (@FirstName, @LastName, @BirthDate)

GO
CREATE PROCEDURE DeleteUser
	@UsersId INT
AS
DELETE FROM Users
WHERE UsersId=@UsersId;

GO
CREATE PROCEDURE DeleteReward
	@RewardsId INT
AS
DELETE FROM Rewards
WHERE RewardsId=@RewardsId;

GO
CREATE PROCEDURE EditUser
	@UsersId INT,
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR (50),
	@BirthDate DATETIME
AS
UPDATE Users
SET FirstName=@FirstName, LastName=@LastName, BirthDate=@BirthDate
WHERE UsersId = @UsersId

GO
CREATE PROCEDURE EditReward
	@RewardsId INT,
	@Title NVARCHAR(50),
	@Description NVARCHAR (250)
AS
UPDATE Rewards
SET Title=@Title, [Description]=@Description
WHERE RewardsId = @RewardsId

GO
CREATE PROCEDURE AddUserReward
	@UsersId INT,
	@RewardsId INT
AS
INSERT INTO UserRewards(UsersId, RewardsId)
VALUES (@UsersId, @RewardsId)

GO
CREATE PROCEDURE DeleteUserReward
	@UsersId INT,
	@RewardsId INT
AS
DELETE FROM UserRewards
WHERE UsersId=@UsersId AND RewardsId=@RewardsId

GO
CREATE PROCEDURE GetRewards
AS
SELECT RewardsId, Title, [Description]  
FROM Rewards

GO
CREATE PROCEDURE GetUsers
AS
SELECT Users.UsersId, Users.FirstName, users.LastName, users.BirthDate, Rewards.RewardsId, Rewards.Title, Rewards.[Description] 
FROM Users 
LEFT JOIN UserRewards ON Users.UsersId = UserRewards.UsersId
LEFT JOIN Rewards ON UserRewards.RewardsId = Rewards.RewardsId;





INSERT INTO Users (FirstName, LastName, BirthDate)
VALUES ('Аверичев','Алексей',1983-05-25);

INSERT INTO Rewards ([Title], [Description])
VALUES ('Шнобелевская','За всякое');

SELECT * FROM Users;
DELETE FROM Users;

DELETE FROM UserRewards;
SELECT * FROM UserRewards;

SELECT * FROM Rewards;
DELETE FROM Rewards;

ALTER TABLE Rewards
ADD UNIQUE ([Title]);

SELECT * FROM Rewards;

SELECT * FROM UserRewards ORDER BY [UsersId];

SELECT * 
FROM Users 
LEFT JOIN UserRewards ON Users.UsersId = UserRewards.UsersId
LEFT JOIN Rewards ON UserRewards.RewardsId = Rewards.RewardsId;

INSERT INTO UserRewards([UsersId],[RewardsId])
VALUES (123, 59);
