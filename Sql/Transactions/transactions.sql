select * from Products
select * from Users
select * from UsersProducts

exec BuyProduct 3, 3

create or alter procedure BuyProduct 
	@ProductId int,
	@UserId int
as
begin
	declare @ProductCount int;
	declare @ProductPrice money;
	declare @UserMoney money;

	select @ProductCount = [Count], @ProductPrice = [Price]
	from [Products]
	where [Id] = @ProductId

	if @ProductCount is null
	begin
		-- throw
		-- raiseerror
		print 'Product not found!'
		return
	end

	if @ProductCount <= 0
	begin
		print 'Product out of stock!'
		return
	end

	select @UserMoney = [Money]
	from [Users]
	where [Id] = @UserId

	if @UserMoney is null
	begin
		print 'User not found!'
		return
	end

	if @UserMoney < @ProductPrice
	begin
		print 'User has not money for this product!'
		return
	end

	begin transaction

		begin try
			waitfor delay '00:00:05';

			update [Products]
			set [Count] = [Count] - 1
			where [Id] = @ProductId

			update [Users]
			set [Money] = [Money] - @ProductPrice
			where [Id] = @UserId

			insert into [UsersProducts] ([UserId], [ProductId])
			values (@UserId, @ProductId)

			commit transaction
		end try
		begin catch
			if @@TRANCOUNT > 0
				rollback
		end catch
end



declare @ProductId int = 2;
declare @UserId int = 3;
declare @ProductCount int;
declare @ProductPrice money;
declare @UserMoney money;

select @ProductCount = [Count], @ProductPrice = [Price]
from [Products]
where [Id] = @ProductId

select @UserMoney = [Money]
from [Users]
where [Id] = @UserId

begin transaction

	begin try 
		update [Products]
		set [Count] = [Count] - 1
		where [Id] = @ProductId

		-- save transaction savepoint1

		update [Users]
		set [Money] = [Money] - @ProductPrice
		where [Id] = @UserId

		-- save transaction savepoint2

		insert into [UsersProducts] ([UserId], [ProductId])
		values (@UserId, @ProductId)
	end try
	begin catch
		rollback transaction;
		throw;
	end catch

commit transaction;