--En çok satılan ürünümün(adet bazında) adı, kategorisinin adı ve tedarikçisinin adı
--61 
SELECT products.product_name, categories.category_name, suppliers.company_name
FROM products
JOIN categories ON products.category_id = categories.category_id
JOIN suppliers ON products.supplier_id = suppliers.supplier_id
WHERE products.product_id = (
    SELECT product_id
    FROM order_details
    GROUP BY product_id
    ORDER BY SUM(quantity) DESC
    LIMIT 1
);

--62
SELECT COUNT(DISTINCT Country)
FROM Customers

--63
select orders.ship_country, count(*) as "müşteri sayısı"
from orders
group by orders.ship_country

--64
Select SUM(order_details.quantity*products.unit_price) from orders 
INNER JOIN employees ON orders.employee_id = employees.employee_id
INNER JOIN order_details ON order_details.order_id = orders.order_id
INNER JOIN products ON order_details.product_id = products.product_id
WHERE employees.employee_id =3 AND order_date >= '1998.01.01';

--65
select sum(order_details.quantity * order_details.unit_price) AS "son 3 aylık ciro"
from order_details
inner join orders on orders.order_id= order_details.order_id 
where order_details.product_id = 10 and orders.order_date > '1997.01.01';

--66
select employees.employee_id,
employees.first_name,
employees.last_name,
count(orders.order_id) AS TotalOrders
from employees
left join orders on employees.employee_id = orders.employee_id
group by employees.employee_id, employees.first_name, employees.last_name
order by TotalOrders desc;

--67
select customers.customer_id, customers.contact_name, orders.order_id
from customers
left join orders on customers.customer_id = orders.customer_id
where orders.order_id IS NULL;

--68
select company_name AS "Şirket Adı",
contact_name AS "Temsilci Adı",
address AS "Adres",
city AS "Şehir",
country AS "Ülke"
from customers
where country='Brazil';

--69
select company_name AS "Şirket Adı",
contact_name AS "Temsilci Adı",
address AS "Adres",
city AS "Şehir",
country AS "Ülke"
from customers
where country <>'Brazil';

--70
select company_name AS "Şirket Adı",
contact_name AS "Temsilci Adı",
address AS "Adres",
city AS "Şehir",
country AS "Ülke"
from customers
where country in ('Spain', 'France', 'Germany')

--71
select *
from customers
where fax is null;

--72
select *
from customers
where city = 'London'or city = 'Paris'

--73 
select *
from customers
where city = 'Mexico D.F' and contact_title = 'Owner'

--74
select product_name , unit_price
from products
where product_name like 'C%';

--75 
select first_name, last_name, birth_date
from employees
where first_name like  'A%';

--76
select company_name 
from customers
where company_name like '%RESTAURANT%';

--77
select product_name, unit_price
from products
where unit_price between 50.0 and 100.0;

--78
select order_id order_date
from orders
where order_date between '1996-07-01' and '1996-12-31';

--79
select company_name AS "Şirket Adı",
contact_name AS "Temsilci Adı",
address AS "Adres",
city AS "Şehir",
country AS "Ülke"
from customers
where country in ('Spain', 'France', 'Germany')

--80
select *
from customers
where fax is null;

--81
select *
from customers
order by country;

--82
selectproduct_name, unit_price
from products
order by unit_price desc;

--83 
select product_name, unit_price
from products
order by unit_price desc, units_in_stock;

--84
select count(*) AS ProductCount
from products
where category_id = 1;

--85
select count(distinct ship_country) AS ExportCount
from orders;
