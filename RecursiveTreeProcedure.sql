CREATE PROCEDURE RecursiveTreeProcedure
AS
BEGIN
	WITH RecursiveTree(Id, ParentId, Name, RecursionLevel)
    AS
    (
        SELECT Id, ParentId, Name, 0 AS RecursionLevel
        FROM Properties
        WHERE ParentId = 0

        UNION ALL

        SELECT prop.Id, prop.ParentId, prop.Name, rec.RecursionLevel + 1
        FROM Properties prop
        INNER JOIN RecursiveTree rec ON prop.ParentId = rec.Id
    )
    SELECT br.Name AS BrandName,prod.[Key] AS ProductCode,br.Id AS BrandId,rt.Id AS RecursionId,prop.ParentId,rt.Name as PropertyName,prod.Name AS ProductName,pp.Value AS ProductValue,RecursionLevel
    FROM RecursiveTree AS rt
    LEFT JOIN ProductProperties AS pp ON pp.PropertyId = rt.Id
	FULL JOIN Products AS prod ON prod.Id = pp.ProductId
	FULL JOIN Properties AS prop ON prop.Id = pp.PropertyId
	FULL JOIN Brand AS br ON br.Id = prod.BrandId
	WHERE RecursionLevel IS NOT NULL
    ORDER BY rt.Id ASC;
END;
