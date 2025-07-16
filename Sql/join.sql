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
select * from GameGenres;

select g.Name, (select Name from GameGenres gg where gg.Code = g.GenreCode)
from Games g;


select *
from Games g;

select g.Name, gg.Name
from Games g
join GameGenres gg on g.GenreCode = gg.Code