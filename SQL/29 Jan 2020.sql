select companyname, productname, unitprice
from suppliers,products
where suppliers.supplierid=products.supplierid
order by companyname, productname;

select c.customerid, c.contactname, o.orderid 
from dbo.customers as c left outer join dbo.orders as o 
on c.customerid = o.CustomerID
order by orderid

select top 15 contactname, orderid
from customers full outer join orders
on customers.CustomerID=orders.CustomerID
order by contactname 

select orderid, lastname, firstname, birthdate, hiredate 
from employees right outer join orders on employees.EmployeeID=orders.EmployeeID;

select productname 
from products where unitsonorder>
(select unitsonorder from products where productname='chang')

select productname, unitprice 
from products 
where categoryid in 
(select categoryid from categories where categoryname = 'Condiments')
order by unitprice

select productname, unitprice 
from products inner join categories
on products.CategoryID=Categories.CategoryID
where categoryname='condiments'

select orderid
from orders
where customerid in (select customerid from orders where orderid in (10252,10473))

select firstname, lastname 
from employees 
where employeeid in (select employeeid from employees where title like '%sales rep%')

select firstname, lastname 
from employees 
where employeeid in (select employeeid from employees where title like '%sales man%')

select productname, unitprice 
from products 
where categoryid = (select categoryid from categories where categoryname='seafood')

select * from categories

select companyname, country, 
(select count(*) from orders where orders.customerid=customers.customerid)
as orders from customers 

select productid, productname, unitprice 
from products 
where unitprice > (select (sum(unitprice) / (select count(*) from products)) as average from products)
order by unitprice 

select (sum(unitprice) / (select count(*) from products)) as average from products

select companyname
from suppliers as s 
where exists 
(select * from products p, categories c 
where p.supplierid=s.supplierid and p.categoryid=c.categoryid and categoryname like '%Dairy%')

select supplierid, companyname 
from suppliers as s where exists 
(select * from categories c, products p 
where c.CategoryID=p.CategoryID and s.SupplierID=p.SupplierID and categoryname like '%produc%')
order by supplierid

select distinct a.productid, a.unitprice as max_unit_price_sold
from [Order Details] as a 
where a.unitprice = 
(
	select max(unitprice)
	from [Order Details] as b
	where a.productid = b.productid
)
order by a.productid


select [order details].orderid,customerid, quantity
from [order details] inner join orders on [Order Details].orderid=orders.orderid where quantity > 20 and productid=6

select od.orderid, quantity, customerid
from [order details] as od inner join orders on od.orderid=orders.orderid 
where Quantity>20 and productid in (select productid from products where productid=6)

select quantity from [order details] 
where productid = (select productid from products where productname like '%boysen%')

select orderid, quantity, productname 
from [order details] inner join products on [order details].productid = products.productid 

select orders.orderid, customerid, productname, quantity 
from orders inner join [Order Details]  
on orders.orderid = [order details].orderid
inner join products on products.productid=[order details].productid
where productname like '%boysen%' and quantity > 20

