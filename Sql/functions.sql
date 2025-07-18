select count(*)
from BlogComments

select count(*)
from BlogComments bc
where bc.reaction = 5

select count(bc.reaction)
from BlogComments bc

select count(*)
from BlogComments bc
where bc.reaction is null

-- count, sum, avg, min, max
select sum(bc.reaction)
from BlogComments bc

select avg(bc.reaction)
from BlogComments bc

declare @minBlogId int = (select min(b.id) from Blogs b)

select * from BlogComments bc where bc.blogid = @minBlogId

select * 
from BlogComments bc
where bc.reaction >= (select avg(reaction) from BlogComments)