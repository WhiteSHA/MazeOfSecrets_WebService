/*CREATE TABLE MazeDataItems (
    id int NOT NULL PRIMARY KEY,
    userId INT DEFAULT 0,
    question NVARCHAR(255) NOT NULL,
    correctAnswer NVARCHAR(255) NOT NULL,
    wrongAnswer1 NVARCHAR(255) NOT NULL,
    wrongAnswer2 NVARCHAR(255) NOT NULL
);*/
/*SET IDENTITY_INSERT MazeDataItems ON*/
/*INSERT INTO MazeDataItems (id,userId,question,correctAnswer,wrongAnswer1,wrongAnswer2) VALUES (2,1,'565asdas','sdfsdf','fghfgh','fghfgh')*/
/*SET IDENTITY_INSERT MazeDataItems OFF */
/*DROP TABLE MazeDataItems*/

/*SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'*/

/*ALTER TABLE dbo.MazeDataItems
ALTER COLUMN wrongAnswer2 VARCHAR(250) COLLATE CYRILLIC_GENERAL_CI_AS;*/

SELECT * FROM MazeDataItems