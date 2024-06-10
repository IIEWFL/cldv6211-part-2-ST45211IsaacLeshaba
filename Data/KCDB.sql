USE master;
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'KhumaloCraft')
DROP DATABASE KhumaloCraft
CREATE DATABASE KhumaloCraft
USE KhumaloCraft

SELECT * FROM AspNetRoles
SELECT * FROM AspNetUsers
SELECT * FROM AspNetUserRoles
SELECT * FROM Products
SELECT * FROM Orders
SELECT * FROM Categories
SELECT * FROM OrderDetails

SELECT p.ProdName, p.Price, c.CatName, p.ImageUrl, p.ProdAvailability, p.PostedBy, p.PostedByRole, p.Stock
FROM [dbo].[Products] p
JOIN [dbo].[Categories] c ON p.CatID = c.CatID



-- seller can see orders that contain their products
-- move view cart and make it better and stle the app
-- can only edit products that you added as a seller or as admin
-- block the relevant pages access wise