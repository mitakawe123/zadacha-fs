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
    SELECT rt.Id AS RecursionId,rt.Name,RecursionLevel,prod.Name AS ProductName,prod.[Key] AS ProductCode,pp.Value AS ProductValue
    FROM RecursiveTree AS rt
    LEFT JOIN ProductProperties AS pp ON pp.PropertyId = rt.Id
	FULL JOIN Products AS prod ON prod.Id = pp.ProductId
	WHERE RecursionLevel IS NOT NULL
    ORDER BY rt.Id ASC;
END;
