-- ascending (min -> max)
select *
from BlogComments bc
order by bc.reaction asc

select *
from BlogComments bc
order by bc.reaction desc, blogid desc