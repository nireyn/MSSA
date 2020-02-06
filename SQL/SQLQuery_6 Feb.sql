with customer1_cte
as
(select orders.customerid, count(orders.customerid) totalNumbers
from orders inner join customers 
on customers.customerid=orders.customerid 
where customers.country = 'usa'
group by orders.customerid) 
select * from customer1_cte order by totalNumbers desc

create view [Brazil Customers] as
select companyname, contactname from customers where country = 'Brazil'

select * from [Brazil Customers]

create view [Current Product LIst Jan 2020] as
select productid, productname from products where Discontinued='0'

select * from [Current Product LIst Jan 2020]

create view customerEmployee as 
select distinct orders.employeeid, orders.customerid, contactname, companyname, lastname, firstname
from orders
inner join customers on customers.customerid = orders.CustomerID
inner join employees on employees.EmployeeID=orders.EmployeeID;

select * from customerEmployee order by employeeid

with customer_orders
as
(select customers.CompanyName, count(orders.orderid) numOrders from customers inner join orders on customers.customerid = orders.customerid
where customers.country = 'usa'
group by customers.companyname)
select * from customer_orders order by numOrders desc

create view [German Customers] 
as
select contactname, companyname, city from customers where country = 'germany'

select * from [German Customers]

select city from customers union select city from suppliers
select city from customers
select city from suppliers

select supplierid 
from suppliers
where supplierid > 10 
intersect
select supplierid 
from products 
where unitsinstock > 0

with customer_orders2
as
(select customers.CompanyName, count(orders.orderid) numOrders from customers inner join orders on customers.customerid = orders.customerid
where customers.country = 'usa'
group by customers.companyname)
select * from customer_orders order by numOrders desc

with customer2_cte
as
(select orders.customerid, count(orders.customerid) totalNumbers
from orders inner join customers 
on customers.customerid=orders.customerid 
where customers.country = 'usa'
group by orders.customerid) 
select * from customer2_cte order by totalNumbers desc

with customer_orders2
as
(select products.productname,  sum([Order Details].Quantity) products from products
inner join suppliers on products.SupplierID=suppliers.SupplierID
inner join [Order Details] on products.ProductID=[Order Details].ProductID
inner join orders on orders.OrderID=[Order Details].OrderID
where suppliers.country = 'germany' and orders.ShipCountry='germany'
group by products.productname)
select * from customer_orders2 order by products desc

create view customerEmployee2 as 
select distinct orders.employeeid, orders.customerid, contactname, companyname, lastname, firstname
from orders
inner join customers on customers.customerid = orders.CustomerID
inner join employees on employees.EmployeeID=orders.EmployeeID;

select * from customerEmployee2