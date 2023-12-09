--1
select product_name, quantity_per_unit
from products;
--2
select product_id, product_name
from porducts
where discontinued = 0;
--3
select product_id, product_name
from products
where discontinued = 1;
--4
select product_id, product_name, unit_price
from products
where unit_price <20;
--5
select product_id, product_name, unit_price
from products
where unit_price BETWEEN 15 AND 25;
--6
select product_name, units_on_order, units_in_stock
from products
where units_in_stock < units_on_order;
--7
select product_name
from products
where product_name like 'a%'
--8
select product_name
from products
where product_name like '%i'
--9
select product_name, unit_price, (unit_price * 1.18) as unit_price_kdv
from products
--10
select count (*) as product_counts
from products
where unit_price >30;
--11
select lower (product_name) as lower_product_name, unit_price
from products
order by unit_price desc;
--12
select concat(firs_name, ' ', first_name) as total_name
from employees;
--13
select count(*) as suppliers_count
from suppliers
where region is null;
--14
select count(*) as suppliers_count
from suppliers
where region is not null;

--15
select concat ('TR', upper (product_name)) as tr_product_name
from products;
--16
select concat ('TR', product_name) as tr_product_name
from products
where unit_price <20;
--17
select product_name, unit_price
from products
where unit_price = (select max(unit_price) from products);

--18
select product_name, unit_price
from products
order by unit_price
limit 10;
--19
select product_name, unit_price
from products
where unit_price > (select avg(unit_price)from products);

--20
select product_name, units_in_stock - units_on_order as quantity_sold
from products
where units_in_stock > units_on_order;
--21
SELECT 
    (SELECT COUNT() FROM products WHERE discontinued = '0') as cont,
    (SELECT COUNT() FROM products WHERE discontinued = '1') as discont;
--22
select product.product_name, categories.category_name
from products
inner join categories on products.category_id = categories.category_id;
--23
select categories.category_name, avg (products.unit_price) as avg_price
from products
inner join categories on products.category_id = categories.category_id
group by categories.category_name
--24
select products.product_name, products.unit_price, categories.category_name
from products
inner join categories on products.category_id = categories.category_id
order by products.unit_price desc
limit 1;

--25
SELECT products.product_name, categories.category_name, suppliers.company_name, SUM(order_details.quantity) AS total_quantity
FROM products
INNER JOIN categories ON products.category_id = categories.category_id
INNER JOIN suppliers ON products.supplier_id = suppliers.supplier_id
INNER JOIN order_details ON products.product_id = order_details.product_id
GROUP BY products.product_name, categories.category_name, suppliers.company_name
ORDER BY total_quantity DESC
LIMIT 1;

--26
select products.product_id, products.product_name, suppliers.company_name, suppliers.phone, products.units_in_stock
from products
inner join suppliers ON products.supplier_id = suppliers.supplier_id
where products.units_in_stock = 0;

--27
select orders.ship_address AS OrderAddress, employees.first_name AS EmployeeFirstName, employees.last_name AS EmployeeLastName
from orders
inner join employees ON orders.employee_id = employees.employee_id
where extract(year from orders.order_date) = 1998 and extract(month from orders.order_date) = 3;
	
--28	
select count(*) OrderCount
from orders
where extract(year from orders.order_date) =1997 and extract(month from orders.order_date) =2	

--29
select count(*) AS OrderCount
from orders
where extract(year from orders.order_date) =1997 and ship_city = 'London';		
	
--30
select customers.contact_name, customers.phone
from customers 
inner join orders on customers.customer_id = orders.customer_id
where extract(year from orders.order_date) =1997

--31
select * from orders
where freight >= 40

--32
select orders.ship_city AS City, customers.contact_name AS CustomerName
from orders 
inner join customers on orders.customer_id = customers.customer_id
where orders.freight >= 40;

--33
select to_char(orders.order_date, 'dd.mm.yyyy') AS OrderDate,
upper(orders.ship_city) AS ShipCity,
concat(upper(employees.first_name),' ', upper(employees.last_name)) AS EmployeeName
from orders
inner join employees on orders.employee_id = employees.employee_id
where extract (year from orders.order_date) = 1997

--34
select customers.contact_name, replace(replace(replace(customers.phone, '(',''),')',''),'','') as formatted_phone
from customers
inner join orders on customers.customer_id = orders.customer_id
where extract (year from orders.order_date) = 1997

--35
select to_char(orders.order_date, 'dd.mm.yyyy') as OrderDate,
	customers.contact_name as CustomerContactName, 
	employees.first_name as EmployeeFirstName,
	employees.last_name as EmployeeLastName
from orders
inner join customers on orders.customer_id = customers.customer_id
inner join employees on orders.employee_id = employees.employee_id;

--36
select orders.order_id AS OrderID,
	to_char(orders.order_date, 'dd.mm.yyyy') AS OrderDate,
	to_char(orders.required_date,'dd.mm.yyyy') AS RequiredDate,
	to_char(orders.shipped_date,'dd.mm.yyyy') AS ShippedDate,
	customers.company_name AS CustomerCompanyName
from orders
inner join customers on orders.customer_id = customers.customer_id
where orders.shipped_date > orders.required_date;

--37
select to_char(orders.order_date, 'dd.mm.yyyy') AS OrderDate,
customers.contact_name AS CustomerName
from orders
inner join customers on orders.customer_id = customers.customer_id
where orders.shipped_date > orders.required_date;

--38
select products.product_name AS ProductName,
categories.category_name AS CategoryName,
order_details.quantity AS Quantity
from order_details
inner join products on order_details.product_id = products.product_id
inner join categories on products.category_id = categories.category_id
where order_details.order_id = 10248;

--39
select products.product_name AS ProductName,
suppliers.company_name AS SupplierName
from order_details
inner join products on order_details.product_id = products.product_id
inner join suppliers on products.supplier_id = suppliers.supplier_id
where order_details.order_id = 10248;

--40
select employees.employee_id, employees.first_name, employees.last_name,
products.product_name, order_details.quantity
from orders
inner join employees on orders.employee_id = employees.employee_id  
inner join order_details on orders.order_id = order_details.order_id
inner join products on order_details.product_id = products.product_id
where employees.employee_id = 3 and extract (year from orders.order_date) = 1997

--41
select employees.employee_id, order_details.order_id,employees.first_name || ' ' || employees.last_name AS "name surname",
count(order_details.order_id) AS "order_count"
from order_details
inner join orders on order_details.order_id = orders.order_id
inner join employees on orders.employee_id = employees.employee_id
where extract(year from order_date) = 1997
group by employees.employee_id, order_details.order_id, employees.first_name, employees.last_name
order by count(order_details.order_id) desc
limit 1;

--42
select employees.employee_id, employees.first_name || ' ' || employees.last_name AS "name surname",
count(orders.employee_id) AS "employees_order_count"
from orders 
inner join employees on orders.employee_id = employees.employee_id
where extract(year from order_date) = 1997
group by employees.employee_id, employees.first_name, employees.last_name
order by count(orders.employee_id) desc
limit 1;

--43
select products.product_name AS ProductName,
products.unit_price AS UnitPrice,
categories.category_name AS CategoryName
from products
inner join categories on products.category_id = categories.category_id
order by products.unit_price desc 
limit 1;

--44
select employees.first_name AS EmployeeFirstName,
employees.last_name AS EmployeeLastName,
orders.order_date AS OrderDate,
orders.order_id AS OrderID
from orders
inner join employees on orders.employee_id = employees.employee_id
order by orders.order_date;

--45
select avg(products.unit_price), orders.order_date, orders.order_id
from orders
inner join order_details on orders.order_id = order_details.order_id
inner join products on order_details.product_id = products.product_id
group by orders.order_date, orders.order_id
order by orders.order_date desc
limit 5;

--46
select products.product_name AS ProductName,
categories.category_name AS CategoryName,
sum(order_details.quantity) AS TotalSales
from order_details
inner join orders on order_details.order_id= orders.order_id
inner join products on order_details.product_id = products.product_id
inner join categories on products.category_id = categories.category_id
where extract (month from orders.order_date)= 1
group by products.product_name, categories.category_name

--47
select orders.order_id AS OrderID,
sum(order_details.quantity) AS TotalSales
from order_details
inner join orders on order_details.order_id = orders.order_id
group by orders.order_id
having avg(order_details.quantity) > (select avg (quantity) from order_details)

--48
select products.product_name AS ProductName,
sum(order_details.quantity) AS TotalQuantity
from orders
inner join order_details ON orders.order_id = order_details.order_id
inner join products ON order_details.product_id = products.product_id
where orders.employee_id = 3
and extract(year from orders.order_date) = 1997
group by products.product_name;

--49
select count (distinct country) from customers

--50
select products.product_name AS ProductName,
sum(order_details.quantity) AS TotalQuantity
from orders
inner join order_details ON orders.order_id = order_details.order_id
inner join products ON order_details.product_id = products.product_id
where orders.employee_id = 3
and extract (year from orders.order_date) = 1997
group by products.product_name;














