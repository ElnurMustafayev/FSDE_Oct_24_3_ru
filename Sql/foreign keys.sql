drop table Games
drop table GameGenres

create table GameGenres (
	[Code] int primary key,
	[Name] varchar(50) not null,
)

insert into GameGenres ([Code], [Name])
values	(100, 'Action'), 
		(200, 'RPG'), 
		(300, 'Strategy'), 
		(400, 'Simulation'), 
		(500, 'Puzzle'), 
		(600, 'Adventure')

create table Games (
	[Id] int primary key identity,
	[Name] varchar(50) not null,
	[GenreCode] int foreign key references GameGenres([Code]) null,
	[Price] money not null
)

INSERT INTO Games ([Name], [GenreCode], [Price]) VALUES
('The Witcher 3', 200, 29.99),
('Civilization VI', 300, 59.99),
('Stardew Valley', 400, 14.99),
('Portal 2', 500, 9.99),
('Minecraft', 600, 26.95),
('Dark Souls III', 100, 39.99),
('Hollow Knight', NULL, 15.00),
('Among Us', 500, 4.99),
('Overwatch', 100, 39.99),
('Divinity: Original Sin 2', 200, 44.99),

('Cities: Skylines', 400, 29.99),
('The Legend of Zelda: BOTW', 600, 59.99),
('XCOM 2', 300, 49.99),
('Celeste', NULL, 19.99),
('DOOM Eternal', 100, 59.99),
('Fire Emblem: Three Houses', 200, 59.99),
('Factorio', 400, 30.00),
('Tetris Effect', 500, 39.99),
('Red Dead Redemption 2', 600, 59.99),
('Slay the Spire', 300, 24.99),

('The Outer Worlds', 200, 39.99),
('FIFA 22', 400, 59.99),
('Cuphead', 100, 19.99),
('Limbo', 500, 9.99),
('Assassin’s Creed Valhalla', 600, 59.99),
('Total War: Warhammer II', 300, 59.99),
('Ori and the Will of the Wisps', NULL, 29.99),
('Monster Hunter: World', 100, 49.99),
('Cities in Motion', 400, 9.99),
('The Talos Principle', 500, 19.99),

('Hades', 100, 24.99),
('Gears 5', 100, 39.99),
('Xenoblade Chronicles 2', 200, 59.99),
('Factorio', NULL, 30.00),
('Age of Empires II', 300, 19.99),
('Kerbal Space Program', 400, 39.99),
('Portal', 500, 9.99),
('Uncharted 4', 600, 59.99),
('Dark Souls II', 200, 39.99),
('The Sims 4', 400, 39.99);

INSERT INTO Games ([Name], [GenreCode], [Price]) 
VALUES ('My game', 356, 539.99);

select *
from Games g
where g.GenreCode in (select top 3 Code from GameGenres)

delete Games
where GenreCode not in (select Code from GameGenres)

select * from GameGenres;

select *
from Games
where Id between 30 and 40

update Games
set GenreCode = 100
where Id = 14