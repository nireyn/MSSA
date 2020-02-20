create procedure dbo.getorders @shipcountry nvarchar(30)
as
select * from dbo.orders where shipcountry = @shipcountry;

exec dbo.getorders @shipcountry = 'Germany';

select * into ordersclone from orders;

delete from ordersclone where shipcountry = 'brazil';

select * into dbo.T2 from employees where country='usa';

