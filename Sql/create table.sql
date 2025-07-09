create database MyAppDb;

use MyAppDb;

-- create
create table Blogs (
	[Title] varchar(100) not null,
	[Description] text null,
	[LikesCount] int not null
)

-- read
select 1

select 'test - ' + [Title]
from Blogs

select len([Title]) + 1000
from Blogs

select [Title], [LikesCount], 150 'num column'
from Blogs

select *
from Blogs

-- insert
insert into Blogs ([Title], [Description], [LikesCount])
values	('My Blog!', null, 0),
		('GTA 6', 'Will be released very soon!!!', 10000)

-- delete
delete Blogs