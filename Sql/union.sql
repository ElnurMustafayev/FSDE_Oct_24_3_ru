select Id, [Name], g.Price
from Games g

union

select Code as Id, [Name], null
from GameGenres