select orderid from orders;
select distinct orderid from orders;
select top(10) * from products;
select productname from dbo.Products;
select productname from products order by productname;
select quantityperunit, unitprice from products order by quantityperunit;
select productid, productname, unitprice from products order by unitprice desc;
select productname, unitprice from products where unitprice >50;
select productname, unitprice from products where productname='tofu';
select productname from products where unitprice = null;
select orderid, sum(unitprice*quantity) as total 
from [Order Details] 
group by orderid
having sum(unitprice*quantity) >=100
order by total desc;

select productid, unitprice, productname from products where supplierid =6 and unitprice <100;
select productname, unitprice from products where supplierid in (1,10) order by productname;
select productname, unitprice, supplierid from products where supplierid not in (1,6) order by supplierid;
select productname from products where productname like 'g%';
select customerid, contactname from customers where contactname collate SQL_Latin1_General_CP1_CS_AS like '%N%';
select companyname +' '+ country NameCountry from suppliers;

select companyname, country from customers where country in ('USA','Canada','mexico') order by country;

select *from orders where orderdate >= '19980401' and orderdate < '19980501' order by orderid;
select orderid, customerid from orders where month(orderdate) = 4 and year(orderdate) = 1998 order by orderid;

select * from products where productname like '%sauce%';
select * from categories;
select * from products where productname like '%dried%';

select * from orders where shipcountry = 'germany' and month(shippeddate) = 12;
select sum((unitprice-discount) * quantity) as TotalWithDiscount, sum(unitprice*quantity) as TotalWithoutDiscount 
from [Order Details] where productid = 19 and discount > 0 ;

select firstname + ' ' + lastname +char(13) + title + char(13) + '__________________' from employees;
select productname, left(productname,4) last_4_characters from products order by productname;
select len(productname) from products order by productname;

select charindex('serv', 'sql server charindex');
select patindex('%ern%', 'sql pattern charindex');
select rtrim(companyname) + '(' + rtrim(country) + ')' from suppliers order by companyname;
select contactname, companyname from customers where soundex(companyname) = soundex('special');
select upper('sql');
select replace('it is a good tea at the famous tea store.', 'tea', 'coffee');
select replicate('z', 3);
select substring('sql server substring',5,6);
select shipname from orders where datepart(month, orderdate)=10;
select customerid, orderid from orders where datediff(day,orderdate,'1996-07-15')=0;
select orderdate, datename(weekday, requireddate) as weekday from orders;
select dateadd(second, 1, '2018-12-31 23:59:59');
select cast(5.95 as int) result;
select isdate('2020-06-15');


select orderid, sum(unitprice*quantity) as TotalSum
from [Order Details]
group by orderid
having sum(unitprice*quantity) > 30 
order by TotalSum Desc;

select companyname, productname, unitprice 
from suppliers inner join products
on suppliers.supplierid = products.supplierid 
order by companyname, productname;

select concat(firstname,' ', lastname) as FullName, orderid, orderdate 
from employees inner join orders 
on employees.employeeid = orders.employeeid 
order by firstname

select customers.customerid, customers.companyname
from customers inner join orders 
on customers.customerid = orders.customerid
where datediff(day, orderdate, '1996-07-15')=0 
and customers.customerid = orders.customerid

select top 10 city, shipname, shipcity 
from orders inner join customers
on orders.customerid = customers.customerid
where (city = 'berlin') or (city like '%d.f.%')
order by city

select productname, companyname, categoryname
from products inner join suppliers on products.supplierid = suppliers.supplierid 
inner join categories on products.categoryid = categories.categoryid

select territorydescription, regiondescription
from territories inner join region on territories.regionid = region.regionid

select companyname, productname
from suppliers inner join products on suppliers.supplierid = products.supplierid
order by companyname

select companyname, productname, unitprice from suppliers cross join products order by companyname, productname

select city, freight, quantity
from orders inner join [Order Details] on orders.orderid= [Order Details].orderid
inner join employees on orders.EmployeeID = employees.EmployeeID
order by city, freight desc

select unitprice, quantity, productid from orders, [Order Details] where orderdate = '1998-05-05' order by productid
select unitprice, quantity, productid from orders inner join [Order Details] on orders.orderid = [Order Details].orderid where orderdate = '1998-05-05' order by productid

select contactname, productname, unitprice from suppliers, products order by contactname

select productname, products.UnitPrice, quantity, orderdate
from products inner join [Order Details] on products.ProductID = [Order Details].ProductID
inner join orders on [Order Details].orderid = orders.orderid 
where orderdate = '1998-05-05'
order by products.UnitPrice

select p1.productid, p1.productname 
from products as p1, products as p2
where p1.supplierid = p2.supplierid and p1.productid = 4

select companyname, concat(firstname, ' ', lastname), quantity 
from orders inner join [Order Details] on orders.orderid = [Order Details].orderid
inner join Employees on orders.EmployeeID = employees.EmployeeID
inner join customers on orders.CustomerID = customers.CustomerID
where shipcountry='france'
order by companyname

select productname, [order details].unitprice, shipcountry
from products inner join [Order Details] on products.ProductID = [Order Details].ProductID
inner join orders on [Order Details].orderid = orders.orderid
where shipcountry like '%xico%'
order by productname

