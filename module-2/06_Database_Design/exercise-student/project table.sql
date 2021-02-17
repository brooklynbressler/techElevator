/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [project_id]
      ,[name]
      ,[from_date]
      ,[to_date]
  FROM [ProjectOrganizer].[dbo].[project]