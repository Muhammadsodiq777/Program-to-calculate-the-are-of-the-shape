IF((SELECT  p.CategoryName
FROM Products p) <> null)
SELECT p.ProductName, c.CategoryName
FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryIDSELECT p.ProductName, c.CategoryName
FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryID
else 
SELECT p.ProductName
FROM Products p
