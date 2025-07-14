drop table Products

create table Products (
	[Id] int primary key identity(1, 1) not null,
	[Name] nvarchar(100) not null,
	[Price] money null,
	[InStock] bit null
)

insert into Products
values ('IPhone', 1500, 1)

insert into Products
values ('Tv', 700, 1)

insert into Products
values ('Toy', 2, null)

insert into Products
values ('IMac', 5000, 1)

select *
from Products

select max(p.Id) + 1
from Products p

delete from Products
where InStock is null