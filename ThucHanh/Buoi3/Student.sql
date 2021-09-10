CREATE DATABASE Results;
USE Results;
CREATE TABLE Students(
	StudentCode char(4) PRIMARY KEY NOT NULL, 
	StudentName char(40)
);

INSERT INTO Students VALUES ('03','Alice');
INSERT INTO Students VALUES ('06','Zidane');
INSERT INTO Students VALUES ('07','Ballack');

CREATE TABLE Exams(
	ExamCode char(10) PRIMARY KEY NOT NULL, 
	ExamName char(20),
	ExamDate datetime
);

INSERT INTO Exams VALUES ('NET01','Introduction to NET','Apr 18 2021');
INSERT INTO Exams VALUES ('NET02','Winform','Apr 19 2021');
INSERT INTO Exams VALUES ('JAV01','Java Basics','Apr 12 2021');
INSERT INTO Exams VALUES ('JAV02','AdvancedJava','Apr 15 2021');

CREATE TABLE Result(
	StudentCode char(4),
	ExamCode char(10), 
	Score int
);

INSERT INTO Result VALUES ('03','NET01',33);
INSERT INTO Result VALUES ('03','NET02',55);
INSERT INTO Result VALUES ('06','JAV01',50);
INSERT INTO Result VALUES ('03','JAV01',60);
INSERT INTO Result VALUES ('06','NET02',67);
INSERT INTO Result VALUES ('07','JAV01',50);
INSERT INTO Result VALUES ('07','NET01',55);
INSERT INTO Result VALUES ('07','NET02',75);

SELECT * FROM Result
SELECT * FROM Students

SELECT S.StudentCode,S.StudentName,R.ExamCode,E.ExamName,R.Score
FROM Result R JOIN Students S ON R.StudentCode=S.StudentCode JOIN Exams E ON R.ExamCode=E.ExamCode
WHERE S.StudentCode='03';
