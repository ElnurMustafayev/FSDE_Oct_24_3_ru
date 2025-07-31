INSERT INTO Countries (Name) VALUES ('Russia');
INSERT INTO Countries (Name) VALUES ('USA');
INSERT INTO Countries (Name) VALUES ('Germany');
INSERT INTO Countries (Name) VALUES ('Japan');
INSERT INTO Countries (Name) VALUES ('Brazil');

INSERT INTO Groups (Name) VALUES ('Group A');
INSERT INTO Groups (Name) VALUES ('Group B');
INSERT INTO Groups (Name) VALUES ('Group C');
INSERT INTO Groups (Name) VALUES ('Group D');
INSERT INTO Groups (Name) VALUES ('Group E');	

INSERT INTO Students (Fullname, BirthDate, CountryId, GroupId)
VALUES ('Ivan Petrov', '2002-05-12', 1, 1);

INSERT INTO Students (Fullname, BirthDate, CountryId, GroupId)
VALUES ('John Smith', '2001-09-23', 2, 2);

INSERT INTO Students (Fullname, BirthDate, CountryId, GroupId)
VALUES ('Hans Müller', '2000-11-15', 3, 3);

INSERT INTO Students (Fullname, BirthDate, CountryId, GroupId)
VALUES ('Yuki Tanaka', '2003-02-28', 4, 1);

INSERT INTO Students (Fullname, BirthDate, CountryId, GroupId)
VALUES ('Carlos Silva', '1999-07-19', 5, 4);

INSERT INTO Students (Fullname, BirthDate, CountryId, GroupId)
VALUES ('Anna Ivanova', '2002-03-03', 1, NULL);

INSERT INTO Students (Fullname, BirthDate, CountryId, GroupId)
VALUES ('Emily Johnson', '2001-12-01', NULL, 2);

INSERT INTO Students (Fullname, BirthDate, CountryId, GroupId)
VALUES ('Takeshi Nakamura', '2000-06-17', 4, 3);

INSERT INTO Students (Fullname, BirthDate, CountryId, GroupId)
VALUES ('Liam Brown', '2003-08-09', 2, 5);

INSERT INTO Students (Fullname, BirthDate, CountryId, GroupId)
VALUES ('Marta Schmidt', '2001-04-21', 3, NULL);