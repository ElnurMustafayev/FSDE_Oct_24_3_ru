create or alter function dbo.GetFullname
(
	@name nvarchar(10),
	@surname nvarchar(10)
)
returns nvarchar(21)
as
begin
	return @name + ' ' + @surname
end

select dbo.GetFullname('Ann', 'Brown')

declare @fullname nvarchar(21) = dbo.GetFullname('Bob', 'Marley')
print @fullname

select @fullname

select len('Test')
select dbo.mylen('Test')

create or alter function dbo.GetUsersCount ()
returns int
as
begin
	return (select count(*) from Users)
end

print dbo.GetUsersCount()



create or alter procedure dbo.MyProc
	@name nvarchar(10)
as
begin
	insert into Users ([Name])
	values (@name)

	select * from Users
end

exec dbo.MyProc 'Bob'