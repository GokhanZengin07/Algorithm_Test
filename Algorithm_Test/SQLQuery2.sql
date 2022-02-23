-- SELECT ContactName ,CompanyName FROM Customers --SELECT SONRASI KOLONLAR
--SELECT ContactName Adi ,CompanyName Sirket FROM Customers --ALias kullanımı
-- ANSI STandart
-- ANSI STandart metinler ' ' ile gösterilir.
-- Select * from Customers where City = 'London'
-- SQL case insensitive - büyük küçük fark etmez
-- Select * from Products where CategoryID=1 or CategoryID=3
-- <> o rakam değil için kullanılır yani UnitPrice<>10 dan farklı olanlar

-- Select * from Products where CategoryID=1 and UnitPrice>10
-- Order by sıra
-- Select * from Products order by CategoryID,ProductName

--Select * from Products order by CategoryID asc --ascending
--Select * from Products order by CategoryID desc --descending

-- Select * from Products where CategoryID=1 order by UnitPrice

-- select count(*) from Products
--select COUNT(*)  from Products
--Select count(*) Adet from Products where CategoryID=2
--Select CategoryID from Products group by CategoryID
--Select CategoryID,count(*) from Products group by CategoryID

--Select CategoryID,count(*),ProductName   from Products group by CategoryID,ProductName
-- select CategoryID,count(*) from Products group by CategoryID having count(*)<10
-- ILK SQL Kodu çalışırken FROM > WHERE > Group By > Having > Select > Order By > Limit

--select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10--

--Select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
--From Products inner join Categories
--on Products.CategoryID=Categories.CategoryID

--DTO DATA TRANSFORMATION OBJECT--
--Inner Joın >> Sadece Eşleşen dataları getirir 

--Select * from Products p inner join [Order Details] od -- boşluk varsa isimlendirmede köşeli parantez
--on p.ProductID=od.ProductID


-- left join // solda olup sağda olmayanlarıda getir
--Select * from Products p left join [Order Details] od -- boşluk varsa isimlendirmede köşeli parantez
--on p.ProductID=od.ProductID
Select * from Customers c left join Orders od 
on c.CustomerID=od.CustomerID
where od.CustomerID is null