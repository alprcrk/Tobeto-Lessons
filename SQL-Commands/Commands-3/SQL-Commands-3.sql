--86
select distinct country from customers order by country asc;

--87
select unit_price from products
order by unit_price desc
limit 5;

--88 
select count(*)as SiparisSayısı 
from orders 
where customer_id='ALFKI';

--89
select sum(unit_price * units_in_stock) AS TotalMaliyet
from products

--90


--91
select avg(unit_price) AS  OrtalamaFiyat 
from products

--92 
select product_name
from products
order by unite_price desc
limit 1

--93
select
    orders.order_id,
    sum(products.unit_price * order_details.quantity) as gain
from
    orders
join
    order_details on orders.order_id = order_details.order_id
join
    products on order_details.product_id = products.product_id
group by
    orders.order_id
order by
    gain
limit 1;


--94
select customer_id, company_name
FROM customers
order by length (company_name) desc
limit 1 ;

--95
select first_name, last_name, extract(year from age (birth_date)) as age
from employees;


--96
select products.product_name,  sum(order_details.quantity) as totalsale
from products
join order_details on products.product_id = order_details.product_id
group by products.product_name
order by totalsale desc;

--97
select orders.order_id AS "Sipariş ID", sum(order_details.unit_price * order_details.quantity) AS "Toplam Kazanç"
from orders
inner join order_details ON orders.order_id = order_details.order_id
group by orders.order_id;

--98
select categories.category_name AS "Kategori Adı", COUNT(products.product_id) AS "Toplam Ürün Sayısı"
from categories
inner join products ON categories.category_id = products.category_id
group by categories.category_name;

--99
select products.product_name AS "Ürün Adı",
sum(order_details.quantity) AS "Toplam Satış Miktarı"
from products
inner join order_details ON products.product_id = order_details.product_id
group by products.product_name
having sum(order_details.quantity) > 1000;

--100
select customers.customer_id, customers.company_name
from customers
left join orders ON customers.customer_id = orders.customer_id
where orders.order_id IS NULL;

--101
select suppliers.company_name as supplier, products.product_name as product
from suppliers
join products on suppliers.supplier_id = products.supplier_id
order by supplier, product;

--102
select orders.order_id AS OrderID,
shippers.company_name AS ShipperName,
orders.shipped_date AS ShippedDate
from orders
inner join shippers ON orders.ship_via = shippers.shipper_id;


--103
select orders.order_id AS OrderID,
customers.contact_name AS CustomerName
from orders
inner join customers on orders.customer_id = customers.customer_id;


--104
select employees.employee_id AS EmployeeID,
concat(employees.first_name, ' ', employees.last_name) AS EmployeeName,
count(orders.order_id) AS TotalOrders
from employees
left join orders on employees.employee_id = orders.employee_id
group by employees.employee_id, EmployeeName
order by TotalOrders desc;


--105
select employees.employee_id AS EmployeeID,
concat(employees.first_name, ' ', employees.last_name) AS EmployeeName,
count(orders.order_id) AS TotalOrders
from employees
left join orders on employees.employee_id = orders.employee_id
group by employees.employee_id, EmployeeName
order by TotalOrders desc
limit 1;


--106
select orders.order_id AS OrderID,
concat(employees.first_name, ' ', employees.last_name) AS EmployeeName,
concat(customers.contact_name, '(', customers.customer_id,')') AS CustomerName
from orders
inner join employees on orders.employee_id = employees.employee_id
inner join customers on orders.customer_id = customers.customer_id;


--107
select products.product_name AS ProductName,
categories.category_name AS CategoryName,
suppliers.company_name AS SupplierName
from products
inner join categories ON products.category_id = categories.category_id
inner join suppliers on products.supplier_id = suppliers.supplier_id;


--108
select orders.order_id,
	   customers.company_name,
	   customers.contact_name,
	   orders.shipped_date,
	   orders.ship_name,
	   products.product_name,
	   order_details.quantity,
	   categories.category_name,
	   suppliers.company_name
from orders 
inner join order_details on order_details.order_id=orders.order_id
inner join customers on customers.customer_id=orders.customer_id
inner join products on products.product_id= order_details.product_id
inner join suppliers on suppliers.supplier_id= products.supplier_id
inner join categories on categories.category_id=products.category_id

--109
select categories.category_id,categories.category_name, products.product_name
from categories
left join products ON categories.category_id = products.category_id
where products.product_id IS NULL;

--110
select *
from customers
where customers.contact_title like '%Manager%'

--111
select *
from customers
where customers.company_name like 'FR%' and len(customers.company_name)=5

--112
select *
from customers
where customers.phone like '(171)%'

--113
select *
from products
where products.quantity_per_unit like '%boxes%'

--114. Fransa ve Almanyadaki (France,Germany) Müdürlerin (Manager) Adını ve Telefonunu listeleyiniz.(MusteriAdi,Telefon)
SELECT c.contact_name, c.phone
FROM customers c
WHERE c.contact_title like '%Manager%' and c.country IN ('France','Germany');

--115. En yüksek birim fiyata sahip 10 ürünü listeleyiniz.
SELECT product_name,unit_price 
from products
order by unit_price desc
limit 10;

--116. Müşterileri ülke ve şehir bilgisine göre sıralayıp listeleyiniz.
select c.country, c.city  from customers c
order by c.country, c.city

--117. Personellerin ad,soyad ve yaş bilgilerini listeleyiniz.
SELECT first_name, last_name, EXTRACT(YEAR FROM AGE(birth_date)) as age
FROM Employees;

--118. 35 gün içinde sevk edilmeyen satışları listeleyiniz.
SELECT *
FROM orders
WHERE order_date < NOW() - INTERVAL '35 days' AND shipped_date IS NULL

--119. Birim fiyatı en yüksek olan ürünün kategori adını listeleyiniz. (Alt Sorgu)
select product_name,unit_price, products.category_id, categories.category_name
from products
JOIN categories ON products.category_id = categories.category_id
order by unit_price desc
limit 1;

-- 120 
select products.product_name, categories.category_name
from products
join categories on products.category_id = categories.category_id
where categories.category_name like '%on%';

-- 121
select products.product_name, sum(order_details.quantity) as totalsalesquantity
from products
join order_details on products.product_id = order_details.product_id
where products.product_name = 'Konbu'
group by products.product_name;


-- 122

select count(distinct products.product_id) as differentproductcount,
suppliers.country as country
from products
join suppliers on products.supplier_id = suppliers.supplier_id
where suppliers.country = 'Japan'
group by suppliers.country;

-- 123

select 
    max(freight) as maxshippingfee,
    min(freight) as minshippingfee,
    avg(freight) as avgshippingfee
from orders
where extract(year from order_date) = 1997;

-- 124

select city, address, fax
from customers
where fax is not null and fax != ''
order by city;

-- 125

select ship_city, ship_name, shipped_date
from orders where orders.shipped_date
between '1996-07-16' and '1996-07-30'
order by shipped_date;