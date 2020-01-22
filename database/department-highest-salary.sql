SELECT
	d.[Name] AS Department,
	e.[Name] AS Employee,
	e.Salary
FROM dbo.Employee e
JOIN dbo.Department d
	ON e.DepartmentId = d.Id
JOIN
(
	SELECT
		DepartmentId,
		MAX(Salary) AS Salary
	FROM dbo.Employee
	GROUP BY
		DepartmentId
) AS hs
	ON e.DepartmentId = hs.DepartmentId AND e.Salary = hs.Salary