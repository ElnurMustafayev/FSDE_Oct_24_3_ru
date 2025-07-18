-- one-to-one

create table Users (
	[id] uniqueidentifier primary key default (newid()),
	[username] nvarchar(50) not null unique
)

create table Blog (
	[id] int primary key identity,
	[title] nvarchar(100) not null,
	[authorId] uniqueidentifier foreign key references Users([id]),
	[description] text not null,
)

create table BlogComments (
	[id] int primary key identity,
	[userid] uniqueidentifier foreign key references Users([id]),
	[text] text not null,
	[reaction] smallint null check([reaction] between 1 and 5)
)

alter table BlogComments
add [blogid] int foreign key references Blog([id]);

EXEC sp_rename 'Blog', 'Blogs';





insert into Users ([username]) values
('alice'),
('bob'),
('charlie');

declare @aliceId uniqueidentifier = (select [id] from Users where username = 'alice');
declare @bobId uniqueidentifier = (select [id] from Users where username = 'bob');
declare @charlieId uniqueidentifier = (select [id] from Users where username = 'charlie');

insert into Blog ([title], [authorId], [description]) values
('How to learn SQL', @aliceId, 'This blog post explains how to get started with SQL databases, best practices, and resources.'),
('Traveling the world on a budget', @bobId, 'Tips and tricks on traveling affordably without compromising experiences.'),
('Top 10 programming languages in 2025', @charlieId, 'An analysis and predictions about the most popular programming languages in the near future.');

declare @blog1 int = (select top 1 [id] from Blog where [title] = 'How to learn SQL');
declare @blog2 int = (select top 1 [id] from Blog where [title] = 'Traveling the world on a budget');
declare @blog3 int = (select top 1 [id] from Blog where [title] = 'Top 10 programming languages in 2025');

insert into BlogComments ([userid], [text], [reaction], [blogid]) values
(@bobId, 'Great post, very helpful for beginners!', 5, @blog1),
(@charlieId, 'I disagree on some points, but overall a good read.', 3, @blog1),
(@aliceId, 'Thanks for sharing these travel tips!', 4, @blog2),
(@bobId, 'Interesting analysis, I use some of these languages.', null, @blog3);




-- username, blogtitle, reaction

select u.username, b.title, bc.reaction 
from BlogComments bc
join Users u on u.id = bc.userid
join Blogs b on b.id = bc.blogid