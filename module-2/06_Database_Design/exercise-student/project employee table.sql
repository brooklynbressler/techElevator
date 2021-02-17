/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [project_id]
      ,[employee_id]
  FROM [ProjectOrganizer].[dbo].[project_employee]