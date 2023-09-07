SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Products p 
LEFT JOIN ProductCategory pc ON p.ProductId = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.CategoryId;