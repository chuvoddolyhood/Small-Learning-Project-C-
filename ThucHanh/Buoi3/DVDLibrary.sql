CREATE DATABASE DVDLibraryNET;
USE DVDLibraryNET;
CREATE TABLE DVDNET(
	DVDCodeNo numeric(9) PRIMARY KEY,
	DVDTitle char(40) NOT NULL,
	[Language] char(20),
	SubTitles bit,
	Price money NOT NULL
)

INSERT INTO DVDNET VALUES ('001','Vuon Sao Bang','Korean','1','120000');
INSERT INTO DVDNET VALUES ('2','Ngoi Nha Hanh Phuc','Korean','1','450000');
INSERT INTO DVDNET VALUES ('003','Noo Chill By Night','Vietnamese','0','100000');
INSERT INTO DVDNET VALUES ('004','KingKong','English','1','1020000');
INSERT INTO DVDNET VALUES ('005','Bo Gia','Vietnamese','1','480000');

SELECT * FROM DVDNET;
SELECT MAX(DVDCodeNo) FROM DVDNET;

SELECT DVDTitle FROM DVDNET WHERE DVDCodeNo=2;
SELECT Language FROM DVDNET WHERE DVDCodeNo=2;


\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\




