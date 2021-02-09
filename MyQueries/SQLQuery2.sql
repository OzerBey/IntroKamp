--müşteriler tablosunda ülkeis farklı olanların listesi
select distinct country from Customers
--müşteriler tablosunda ülkesi farklı olanların sayısı
select count(distinct Country) as farklı_olanlarinSayisi from Customers
--examples for not conditions
select * from Customers where not City in('Berlin', 'München')
-- combine AND OR and NOT
select * from Customers where Country='Germany' and (City='Berlin' or  City='München')
select * from Customers where not Country='Germany' and not Country='USA' and not Country ='France'
--using order by 
select * from Customers order by Country desc
select * from Customers order by City,Country

select * from Customers order by Country asc, ContactName desc
--using INSERT INTO
INSERT INTO Customers (ContactName,City, PostalCode)
VALUES ('OZER','Ysn','21','4006');
select * from Customers where CompanyName in('Ozer')











