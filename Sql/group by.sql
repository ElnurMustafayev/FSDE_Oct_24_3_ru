select distinct bc.blogid
from BlogComments bc

select bc.blogid, count(bc.reaction) 'count', sum(bc.id) idsum
from BlogComments bc
group by bc.blogid
having sum(bc.id) % 2 = 0

-- 5 select
-- 1 from
-- 2 where
-- 3 group by 
-- 4 having 

select bc.blogid, count(bc.reaction) 'count', sum(bc.id) idsum
from BlogComments bc
join Blogs b on bc.blogid = b.id
where b.id > 2
group by bc.blogid
having sum(bc.id) % 2 = 1