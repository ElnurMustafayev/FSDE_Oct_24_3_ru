create table [Products] (
	[Id] int primary key identity,
	[Name] nvarchar(100) unique not null,
	[Price] money not null check([Price] >= 0),
	[Count] int not null default(0) check([Count] >= 0)
)

create table [Users] (
	[Id] int primary key identity,
	[Name] nvarchar(100) not null,
	[Email] varchar(100) unique not null check([Email] like '%@%.%'),
	[Money] money not null check([Money] >= 0)
)

create table [UsersProducts] (
	[Id] int primary key identity not null,
	[CreatedDateTime] datetime2 default(GETDATE()),
	[UserId] int foreign key references Users([Id]) not null,
	[ProductId] int foreign key references Products([Id]) not null
)