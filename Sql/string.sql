char()
nchar()
varchar()
nvarchar()

create table Employee (
	[Name] char(30)		-- 30 bytes
)

create table Employee (
	[Name] varchar(30)		-- N + 2 bytes
)

create table Employee (
	[Name] nvarchar(30)		-- (N*2) + 2 bytes
)

insert into Employee
values	(N'������'),
		(N'Bob'),
		(N'Ann')

select *
from Employee

select *
from Employee e
where e.Name not like N'�%'

delete Employee
drop table Employee