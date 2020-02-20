select city from customers union select city from suppliers order by city

select city, country 
from customers where country = 'germany' 
union all select city, country
from suppliers where country ='germany' order by city;

select supplierid from suppliers where supplierid > 10 
intersect select supplierid from products where unitsinstock > 0;

select companyname from customers except select companyname from suppliers

select country from customers union select country from suppliers
select city, country from customers union select city, country from suppliers
select country from customers intersect select country from suppliers
select city, country from customers intersect select city, country from suppliers
select country from customers except select country from suppliers
select country from suppliers except select country from customers

select count(*) over () numEmployees, firstname, lastname, hiredate 
from employees order by hiredate

select (select count(*) from employees) numEmployees, firstname, lastname, hiredate 
from employees order by hiredate

select count(*) over (partition by month(hiredate), year(hiredate)) as numPermonth, 
datename(month,hiredate)+' '+ datename(year,hiredate) as TheMonth,
firstname lastname from employees order by hiredate

select count(*) over () numProducts, productname, unitprice 
from products order by unitprice

select row_number() over 
(order by year(hiredate), month(hiredate)) StartingRank,
Rank() over (order by year(hiredate), month(hiredate)) EmployeeRank,
dense_rank() over (order by year(hiredate), month(hiredate)) DenseRank,
Datename(month,hiredate)+' '+ datename(year,hiredate) TheMonth,
firstname,lastname,hiredate from employees order by hiredate

create table student
(
Studentid int not null,
exam1 int,
exam2 int,
exam3 int
)
insert into student(studentid, exam1, exam2, exam3) values
(1, 77, 55, 90),
(2,98,97,86),
(3,67,54,35),
(4,35,87,77),
(5,90,35,87)

select * from student

select top 10 * from [Order Details] order by productid

select 'TotalOrder' as totalorderbyproductid, [1], [2] 
from 
(select productid, quantity 
from [Order Details]) as sourcetable 
pivot (
sum(quantity) 
for productid in ([1],[2])
) as PivotTable

Select 'TotalScore' as totalExamScore, [1],[2],[3],[4],[5] 
from
(select studentid, exam1 from student) sourcetable 
pivot (
sum(exam1)for studentid in ([1],[2],[3],[4],[5])) as pivottable

Select 'TotalScore' as totalExamScore, [1],[2],[3],[4],[5] 
from
(select studentid, (exam1+ exam2 +exam3) totalscore from student) sourcetable 
pivot (
sum(totalscore)for studentid in ([1],[2],[3],[4],[5])) as pivottable

select (exam1 + exam2+ exam3) totalscore from student