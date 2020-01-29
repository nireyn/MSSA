select customers.custid, count(distinct orders.orderid) numorders, sum(qty) totalqty
from sales.customers inner join sales.orders on sales.customers.custid = sales.orders.custid
inner join sales.OrderDetails on sales.orders.orderid = sales.OrderDetails.orderid
where country = 'USA'
group by customers.custid

select c.custid, companyname, orderid, orderdate
from sales.customers as c inner join sales.orders as o on c.custid = o.custid
where orderdate='20160212'

select c.custid, c.companyname, o.orderid
from sales.customers as c 
left outer join sales.orders as o
on c.custid = o.custid

select c.custid, c.companyname, o.orderid, o.orderdate
from sales.customers as c left outer join sales.orders as o on c.custid=o.custid

