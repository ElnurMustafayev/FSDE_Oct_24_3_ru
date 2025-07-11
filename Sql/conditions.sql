select *
from Blogs
where LikesCount > 5000 or Title = 'GTA 6'

select *
from Blogs
where Title like 'Heart of %' -- 'a%a'

select *
from Blogs
where Title like '%a%'

select *
from Blogs
where Blogs.LikesCount <= 1000

select *
from Blogs b
where b.LikesCount >= 100 and b.LikesCount <= 200

select *
from Blogs b
where b.LikesCount between 100 and 200

delete from Blogs
where Blogs.Description is null