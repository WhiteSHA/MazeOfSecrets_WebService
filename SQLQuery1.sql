/*CREATE TABLE MazeDataItems (
    id int IDENTITY(1,1) PRIMARY KEY,
    userId INT DEFAULT 0,
    question VARCHAR(255) NOT NULL,
    correctAnswer VARCHAR(255) NOT NULL,
    wrongAnswer1 VARCHAR(255) NOT NULL,
    wrongAnswer2 VARCHAR(255) NOT NULL
);*/
SET IDENTITY_INSERT MazeDataItems ON
INSERT INTO MazeDataItems (id,userId,question,correctAnswer,wrongAnswer1,wrongAnswer2) VALUES (2,1,'565asdas','sdfsdf','fghfgh','fghfgh')
SET IDENTITY_INSERT MazeDataItems OFF 
/*DROP TABLE MazeDataItems*/

/*SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'*/

SELECT * FROM MazeDataItems