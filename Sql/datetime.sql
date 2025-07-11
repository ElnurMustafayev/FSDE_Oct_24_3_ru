date
time
datetime		-- 8 bytes
datetime2		-- 6-8 bytes

create table Employees (
	[Name] nvarchar(30),
	[EnterDateTime] datetime2
)

insert into Employees ([Name], [EnterDateTime])
values	('Ann', '2025-07-11 10:20:30.456789'),
		('Bob', '2025-07-11')

select *
from Employees e
where e.EnterDateTime >= '2025-07-11'