USE [BizRunTime]
GO

UPDATE [dbo].[Student]
   SET [ID] = 5, 
       [NAME] = 'Sanvi',
       [AGE] = 12,
       [SALARY] = 5000
 WHERE ID = 4;
GO


