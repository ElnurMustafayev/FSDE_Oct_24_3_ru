create table Countries (
	[Code] int primary key,
	[Name] nvarchar(50) not null,
	[Capital] nvarchar(50) not null,
	[Population] int null,
)

insert into Countries (Code, Name, Capital, Population) values
(840, 'United States', 'Washington, D.C.', 331000000),
(124, 'Canada', 'Ottawa', 38000000),
(250, 'France', 'Paris', 67000000),
(276, 'Germany', 'Berlin', 83000000),
(392, 'Japan', 'Tokyo', 125000000),
(156, 'China', 'Beijing', 1410000000),
(356, 'India', 'New Delhi', 1400000000),
(826, 'United Kingdom', 'London', 67000000),
(643, 'Russia', 'Moscow', 145000000),
(31, 'Azerbaijan', 'Baku', 10000000);



create table Users (
	[Id] int primary key identity,
	[Email] varchar(100) not null unique check([Email] like '%@%'),
	[Name] nvarchar(50) not null check(lower([Name]) != lower('Bob')),
	[Surname] nvarchar(50) not null default('UNKNOWN'),
	[BirthDate] datetime2 null check([BirthDate] < GETDATE()),
	[CountryCode] int foreign key references Countries([Code])
)

insert into Users (Email, Name, BirthDate, CountryCode) values 
('alice.usa@example.com', 'Alice', '1990-05-12', 840),
('john.canada@example.com', 'John', '1985-09-23', 124),
('emma.fr@example.com', 'Emma', '1992-01-15', 250),
('liam.de@example.com', 'Liam', '1988-07-30', 276),
('sophia.jp@example.com', 'Sophia', '1995-03-11', 392),
('noah.cn@example.com', 'Noah', '1993-12-20', 156),
('olivia.in@example.com', 'Olivia', '1991-04-05', 356),
('james.uk@example.com', 'James', '1980-08-17', 826),
('ava.ru@example.com', 'Ava', '1996-11-09', 643),
('mia.az@example.com', 'Mia', '1994-06-02', 31),
('lucas.usa@example.com', 'Lucas', '1989-10-21', 840),
('isabella.can@example.com', 'Isabella', '1984-05-03', 124),
('ethan.fr@example.com', 'Ethan', '1990-01-30', 250),
('amelia.de@example.com', 'Amelia', '1997-02-14', 276),
('logan.jp@example.com', 'Logan', '1992-08-27', 392),
('harper.cn@example.com', 'Harper', '1986-12-01', 156),
('ben.in@example.com', 'Benjamin', '1987-07-14', 356),
('charlotte.uk@example.com', 'Charlotte', '1993-09-18', 826),
('daniel.ru@example.com', 'Daniel', '1982-03-07', 643),
('grace.az@example.com', 'Grace', '1995-11-23', 31),
('jack.usa@example.com', 'Jack', '1991-06-10', 840),
('ella.can@example.com', 'Ella', '1989-04-25', 124),
('henry.fr@example.com', 'Henry', '1983-01-12', 250),
('chloe.de@example.com', 'Chloe', '1996-08-04', 276),
('sebastian.jp@example.com', 'Sebastian', '1984-10-19', 392)



select top 10 *
from Users u
join Countries c on u.CountryCode = c.Code


insert into Users (Email, Name, BirthDate, CountryCode) values 
('alice.usa@gmail.com', 'alice', '2010-01-01', 840)

select *
from Users u
where u.Email = 'alice.usa@gmail.com'