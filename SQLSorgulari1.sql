Select * from Customers
Select ContactName Adi, CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City='London'

Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products order by CategoryID,ProductName

select * from Products order by UnitPrice asc --ascending

select * from Products where categoryId = 1 order by UnitPrice desc --ascending

select count(*) from Products

select count(*) from Products where CategoryID = 2

--hangi kategoride kaç farklı ürünümüz var
select count(*) UrunSayisi,CategoryID KategoriNumarasi from Products group by CategoryID

--ürün sayısı 10dan az olan kategorileri listele
select count(*) UrunSayisi,CategoryID KategoriNumarasi 
from Products
where UnitPrice>20 
group by CategoryID having COUNT(*)<10
--Sorguda önce where kısmından başlanır.

--bana sayısını ver
--ürünlerin
--ama unitPrice'ı 20 birimden küçük olanlar.

--bunları categoryId'sine göre gruplandır. 
--Yani yukarıdaki istenilenleri tüm kategoriler için ayrı ayrı yap.
--ama 10 taneden daha az olan kategoriler için bunu yapma.

select Products.ProductID,Products.ProductName,Categories.CategoryName,
Products.UnitPrice
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10
order by Products.UnitPrice

--products tablosundan id, isim ve kategori tablosundan kategori ismini
--ürünler ve kategoriler tablolarını kullanarak getir.
--her iki tablodada CategoryId var. Bak, bunları eşitle. ona göre getir.
--bide ürünler tablosundaki unitPrice'ı 10dan büyük olanları getir.


select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

select * from customers c inner join Orders o
on c.CustomerID = o.CustomerID
--sistemde kayıtlı müşteriler ve bağlantılı oldukları siparişleri getir.
--830 tane

select * from customers c left join Orders o
on c.CustomerID = o.CustomerID
--sistemdeki kayıtlı tüm müşteriler ve siparişleri getir.

select * from customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
--sorguda primary key null olamayacağı için where'de pk sorgulanır.
--sistemdeki kayıtlı tüm müşteri bilgilerini ve siparişleri getir.
--ama siparişle bağlantısı olmayan müşterileri getir.


select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID